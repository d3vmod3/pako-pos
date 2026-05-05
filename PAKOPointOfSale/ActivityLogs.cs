using System;
using System.Data.SqlClient;
using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace PAKOPointOfSale
{
    public static class ActivityLogs
    {
        public static void Log(
            string user,
            string action,
            string module,
            string description,
            object payload = null)
        {
            string connString = Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO ActivityLogs 
                        (timestamp, [user], action, module, description, payload)
                        VALUES 
                        (@timestamp, @user, @action, @module, @description, @payload)
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@module", module);
                        cmd.Parameters.AddWithValue("@description", description);

                        string jsonPayload = payload != null
                            ? JsonSerializer.Serialize(payload)
                            : null;

                        cmd.Parameters.AddWithValue("@payload", (object?)jsonPayload ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Don't break POS flow
                Console.WriteLine("Logging failed: " + ex.Message);
            }
        }
    }
}