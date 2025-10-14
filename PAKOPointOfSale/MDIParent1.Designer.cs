namespace PAKOPointOfSale
{
    partial class SuperAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            setupToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            supplierProductsToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem1 = new ToolStripMenuItem();
            userAccessControlToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            resetAllToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            setupToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { setupToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // setupToolStripMenuItem
            // 
            setupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem, usersToolStripMenuItem, supplierProductsToolStripMenuItem, suppliersToolStripMenuItem, transactionsToolStripMenuItem, usersToolStripMenuItem1, userAccessControlToolStripMenuItem, setupToolStripMenuItem1 });
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(49, 20);
            setupToolStripMenuItem.Text = "Setup";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(180, 22);
            categoriesToolStripMenuItem.Text = "Categories";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(180, 22);
            usersToolStripMenuItem.Text = "Products";
            // 
            // supplierProductsToolStripMenuItem
            // 
            supplierProductsToolStripMenuItem.Name = "supplierProductsToolStripMenuItem";
            supplierProductsToolStripMenuItem.Size = new Size(180, 22);
            supplierProductsToolStripMenuItem.Text = "Supplier Products";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(180, 22);
            suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(180, 22);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // usersToolStripMenuItem1
            // 
            usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            usersToolStripMenuItem1.Size = new Size(180, 22);
            usersToolStripMenuItem1.Text = "Users";
            usersToolStripMenuItem1.Click += usersToolStripMenuItem1_Click;
            // 
            // userAccessControlToolStripMenuItem
            // 
            userAccessControlToolStripMenuItem.Name = "userAccessControlToolStripMenuItem";
            userAccessControlToolStripMenuItem.Size = new Size(180, 22);
            userAccessControlToolStripMenuItem.Text = "User Access Control";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetAllToolStripMenuItem, logoutToolStripMenuItem1 });
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(61, 20);
            logoutToolStripMenuItem.Text = "Settings";
            // 
            // resetAllToolStripMenuItem
            // 
            resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            resetAllToolStripMenuItem.Size = new Size(119, 22);
            resetAllToolStripMenuItem.Text = "Reset All";
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(119, 22);
            logoutToolStripMenuItem1.Text = "Logout";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // setupToolStripMenuItem1
            // 
            setupToolStripMenuItem1.Name = "setupToolStripMenuItem1";
            setupToolStripMenuItem1.Size = new Size(180, 22);
            setupToolStripMenuItem1.Text = "Setup";
            // 
            // SuperAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SuperAdminForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin";
            WindowState = FormWindowState.Maximized;
            Load += SuperAdminForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem setupToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem supplierProductsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem1;
        private ToolStripMenuItem userAccessControlToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem setupToolStripMenuItem1;
    }
}



