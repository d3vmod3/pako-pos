using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PAKOPointOfSale
{
    public static class LoggedInUser
    {
        public static string CurrentUser { get; set; } = "";
        public static int CurrentUserTypeId { get; set; }

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

            currentForm.Hide();
            var loginForm = new Login(); // Replace with your login form
            loginForm.Show();
            currentForm.Close();
        }
    }
}
