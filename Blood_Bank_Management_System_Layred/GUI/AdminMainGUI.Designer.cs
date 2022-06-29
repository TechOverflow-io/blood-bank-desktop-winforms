namespace Blood_Bank_Management_System_Layred.GUI
{
    partial class AdminMainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDonorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByBloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveDemandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.searchBloodDonorToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.deleteDonorToolStripMenuItem,
            this.approveDemandToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonorToolStripMenuItem,
            this.updateDonorDetailsToolStripMenuItem,
            this.viewAllDonorsDetailsToolStripMenuItem});
            this.donorToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Donor;
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(137, 64);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonorToolStripMenuItem
            // 
            this.addNewDonorToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Add_new;
            this.addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            this.addNewDonorToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.addNewDonorToolStripMenuItem.Text = "Add New Donor";
            this.addNewDonorToolStripMenuItem.Click += new System.EventHandler(this.addNewDonorToolStripMenuItem_Click);
            // 
            // updateDonorDetailsToolStripMenuItem
            // 
            this.updateDonorDetailsToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Update_details;
            this.updateDonorDetailsToolStripMenuItem.Name = "updateDonorDetailsToolStripMenuItem";
            this.updateDonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.updateDonorDetailsToolStripMenuItem.Text = "Update Donor Details";
            this.updateDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDonorDetailsToolStripMenuItem_Click);
            // 
            // viewAllDonorsDetailsToolStripMenuItem
            // 
            this.viewAllDonorsDetailsToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Details;
            this.viewAllDonorsDetailsToolStripMenuItem.Name = "viewAllDonorsDetailsToolStripMenuItem";
            this.viewAllDonorsDetailsToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.viewAllDonorsDetailsToolStripMenuItem.Text = "View All Donors Details";
            this.viewAllDonorsDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDonorsDetailsToolStripMenuItem_Click);
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            this.searchBloodDonorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByLocationToolStripMenuItem,
            this.searchByBloodGroupToolStripMenuItem});
            this.searchBloodDonorToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.search_user;
            this.searchBloodDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            this.searchBloodDonorToolStripMenuItem.Size = new System.Drawing.Size(272, 64);
            this.searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // searchByLocationToolStripMenuItem
            // 
            this.searchByLocationToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Location;
            this.searchByLocationToolStripMenuItem.Name = "searchByLocationToolStripMenuItem";
            this.searchByLocationToolStripMenuItem.Size = new System.Drawing.Size(313, 34);
            this.searchByLocationToolStripMenuItem.Text = "Search By Location";
            this.searchByLocationToolStripMenuItem.Click += new System.EventHandler(this.searchByLocationToolStripMenuItem_Click);
            // 
            // searchByBloodGroupToolStripMenuItem
            // 
            this.searchByBloodGroupToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Blood_group;
            this.searchByBloodGroupToolStripMenuItem.Name = "searchByBloodGroupToolStripMenuItem";
            this.searchByBloodGroupToolStripMenuItem.Size = new System.Drawing.Size(313, 34);
            this.searchByBloodGroupToolStripMenuItem.Text = "Search By Blood Group";
            this.searchByBloodGroupToolStripMenuItem.Click += new System.EventHandler(this.searchByBloodGroupToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem,
            this.stockDetailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.stock;
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(129, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Inc;
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.increaseToolStripMenuItem.Text = "Increase";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Dec;
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Details;
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.stockDetailsToolStripMenuItem.Text = "Stock Details";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteDonorToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.delete_donor;
            this.deleteDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(205, 64);
            this.deleteDonorToolStripMenuItem.Text = "Delete Donor";
            this.deleteDonorToolStripMenuItem.Click += new System.EventHandler(this.deleteDonorToolStripMenuItem_Click);
            // 
            // approveDemandToolStripMenuItem
            // 
            this.approveDemandToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.bloodDrop;
            this.approveDemandToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.approveDemandToolStripMenuItem.Name = "approveDemandToolStripMenuItem";
            this.approveDemandToolStripMenuItem.Size = new System.Drawing.Size(247, 64);
            this.approveDemandToolStripMenuItem.Text = "Approve Demand";
            this.approveDemandToolStripMenuItem.Click += new System.EventHandler(this.approveDemandToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.LogOut2;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(156, 64);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // AdminMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 743);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainGUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminMainGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDonorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByBloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveDemandToolStripMenuItem;

    }
}