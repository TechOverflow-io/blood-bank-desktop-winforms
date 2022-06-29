namespace Blood_Bank_Management_System_Layred.GUI
{
    partial class HManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByBloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBloodDonorToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.requestBloodToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 68);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.stockDetailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.stock;
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(129, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Details;
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.stockDetailsToolStripMenuItem.Text = "Stock Details";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
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
            // requestBloodToolStripMenuItem
            // 
            this.requestBloodToolStripMenuItem.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.bloodDrop;
            this.requestBloodToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.requestBloodToolStripMenuItem.Name = "requestBloodToolStripMenuItem";
            this.requestBloodToolStripMenuItem.Size = new System.Drawing.Size(217, 64);
            this.requestBloodToolStripMenuItem.Text = "Request Blood";
            this.requestBloodToolStripMenuItem.Click += new System.EventHandler(this.requestBloodToolStripMenuItem_Click);
            // 
            // HManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 774);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HManager";
            this.Text = "HManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByBloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestBloodToolStripMenuItem;
    }
}