using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAKOPointOfSale
{
    public static class BackupDatabase
    {
        public static string _backupFile;
        public static void backup()
        {
            try
            {
                string appPath = Application.StartupPath;
                string backupLocation = getBackupLocation();
                string backupFolder = !string.IsNullOrEmpty(backupLocation) ? backupLocation : Path.Combine(appPath, "Backups");
                string dbName = "db_pos";
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string backupFile = Path.Combine(backupFolder, $"{dbName}_{timestamp}.bak");
                _backupFile = backupFile;

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

        public static string getBackupLocation()
        {
            string location = "";
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"SELECT [key],value FROM options where [key]='backup_database_location'";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                location = reader["value"].ToString();
                                return location;
                            }
                            else
                            {
                                MessageBox.Show("Path doesn't exist!");
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user: " + ex.Message);
            }

            return null;
        }
    }
}
