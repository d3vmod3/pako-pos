using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Options
{
    public partial class Options : Form
    {
        public string SelectedOption;
        public Options()
        {
            InitializeComponent();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (SelectedOption != "")
            {
                switch (SelectedOption)
                {
                    case "Activity Logs":
                        grpBoxActivityLogs.Visible = true;
                        grpBoxBackupDatabase.Visible = false;
                        break;
                    case "Backup Database":
                        grpBoxActivityLogs.Visible = false;
                        grpBoxBackupDatabase.Visible = true;
                        loadBackupDatabaseLocation();
                        break;
                    default:
                        MessageBox.Show("Invalid option selected.");
                        break;
                }
            }

        }

        private void loadBackupDatabaseLocation()
        {
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
                                txtDbaseLocation.Text = reader["value"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Option key not found.");
                                this.Close();
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
        }

        private void lstOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOptions.Items.Count != 0)
            {
                switch (lstOptions.SelectedItem)
                {
                    case "Activity Logs":
                        grpBoxActivityLogs.Visible = true;
                        grpBoxBackupDatabase.Visible = false;
                        break;
                    case "Backup Database":
                        grpBoxActivityLogs.Visible = false;
                        grpBoxBackupDatabase.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Invalid option selected.");
                        break;
                }
            }
        }

        private void btnSaveDbaseBackupLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                if (!Path.Exists(txtDbaseLocation.Text))
                {
                    MessageBox.Show("Path not found. Please choose a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"UPDATE options SET value=@value WHERE [key]='backup_database_location'";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", txtDbaseLocation.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Backup database location updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error updating backup database location.");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving backup database location: " + ex.Message);
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDbaseBackupLocation.ShowDialog();
            txtDbaseLocation.Text = folderBrowserDialogDbaseBackupLocation.SelectedPath;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupDatabase.backup();
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Options > Backup database",
                description: "Backup Database",
                payload: new
                {
                    file = BackupDatabase._backupFile
                }
            );
        }
    }
}
