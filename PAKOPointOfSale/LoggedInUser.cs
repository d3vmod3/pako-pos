using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PAKOPointOfSale
{
    public static class LoggedInUser
    {
        public static string CurrentUser { get; set; } = "";
        public static int CurrentUserTypeId { get; set; }
        public static string FirstName { get; set; } = "";
        public static string LastName { get; set; } = "";
        public static string FullName => $"{FirstName} {LastName}".Trim();
        public static bool HasPermission(string moduleName, string action)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    string query = @"
                        SELECT can_view, can_add, can_edit, can_delete
                        FROM Permissions
                        WHERE user_type_id = @userTypeId
                          AND module_name = @moduleName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userTypeId", CurrentUserTypeId);
                        cmd.Parameters.AddWithValue("@moduleName", moduleName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool canView = reader.GetBoolean(reader.GetOrdinal("can_view"));
                                bool canAdd = reader.GetBoolean(reader.GetOrdinal("can_add"));
                                bool canEdit = reader.GetBoolean(reader.GetOrdinal("can_edit"));
                                bool canDelete = reader.GetBoolean(reader.GetOrdinal("can_delete"));

                                return action.ToLower() switch
                                {
                                    "view" => canView,
                                    "add" => canAdd,
                                    "edit" => canEdit,
                                    "delete" => canDelete,
                                    _ => false
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission check failed: " + ex.Message);
            }

            return false;
        }
        public static void Logout(Form currentForm)
        {
            CurrentUser = "";
            CurrentUserTypeId = 0;
            backupDatabase();
            currentForm.Hide();
            var loginForm = new Login(); // Replace with your login form
            loginForm.Show();

            currentForm.Close();

        }

        private static void backupDatabase()
        {
            try { 
                string appPath = Application.StartupPath;
                string backupFolder = Path.Combine(appPath, "Backups");
                string dbName = "db_pos";
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string backupFile = Path.Combine(backupFolder, $"{dbName}_{timestamp}.bak");

                // Make sure the folder exists
                if (!Directory.Exists(backupFolder))
                    Directory.CreateDirectory(backupFolder);

                string connectionString = Program.ConnString;
                string backupQuery = $@"
                    BACKUP DATABASE [{dbName}]
                    TO DISK = N'{backupFile}'
                    WITH COMPRESSION;
                ";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Database backup completed:\n{backupFile}",
                    "Backup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Backup failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
