namespace Blood_Bank_Management_System_Layred.GUI
{
    partial class HMRequestBloodGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMRequestBloodGroup));
            this.txtBloodGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.txtUnits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnRequestBlood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.txtBloodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBloodGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBloodGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBloodGroup.FocusedState.Parent = this.txtBloodGroup;
            this.txtBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtBloodGroup.ForeColor = System.Drawing.Color.Black;
            this.txtBloodGroup.HoverState.Parent = this.txtBloodGroup;
            this.txtBloodGroup.ItemHeight = 30;
            this.txtBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.txtBloodGroup.ItemsAppearance.Parent = this.txtBloodGroup;
            this.txtBloodGroup.Location = new System.Drawing.Point(274, 120);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.ShadowDecoration.Parent = this.txtBloodGroup;
            this.txtBloodGroup.Size = new System.Drawing.Size(319, 36);
            this.txtBloodGroup.TabIndex = 121;
            this.txtBloodGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.Black;
            this.lblBloodGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBloodGroup.Location = new System.Drawing.Point(92, 125);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(176, 31);
            this.lblBloodGroup.TabIndex = 120;
            this.lblBloodGroup.Text = "Blood Group";
            this.lblBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnits
            // 
            this.txtUnits.BackColor = System.Drawing.Color.Transparent;
            this.txtUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnits.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnits.FocusedState.Parent = this.txtUnits;
            this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtUnits.ForeColor = System.Drawing.Color.Black;
            this.txtUnits.HoverState.Parent = this.txtUnits;
            this.txtUnits.ItemHeight = 30;
            this.txtUnits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtUnits.ItemsAppearance.Parent = this.txtUnits;
            this.txtUnits.Location = new System.Drawing.Point(274, 203);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.ShadowDecoration.Parent = this.txtUnits;
            this.txtUnits.Size = new System.Drawing.Size(319, 36);
            this.txtUnits.TabIndex = 123;
            this.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.BackColor = System.Drawing.Color.Transparent;
            this.lblUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.Color.Black;
            this.lblUnits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnits.Location = new System.Drawing.Point(180, 203);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(82, 31);
            this.lblUnits.TabIndex = 122;
            this.lblUnits.Text = "Units";
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(-21, 71);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1228, 10);
            this.guna2Separator1.TabIndex = 124;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Balsamiq Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitle.Location = new System.Drawing.Point(168, -22);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(475, 105);
            this.lbltitle.TabIndex = 125;
            this.lbltitle.Text = "Request Blood";
            // 
            // btnRequestBlood
            // 
            this.btnRequestBlood.BackColor = System.Drawing.Color.Transparent;
            this.btnRequestBlood.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRequestBlood.BorderRadius = 20;
            this.btnRequestBlood.BorderThickness = 2;
            this.btnRequestBlood.CheckedState.Parent = this.btnRequestBlood;
            this.btnRequestBlood.CustomImages.Parent = this.btnRequestBlood;
            this.btnRequestBlood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRequestBlood.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRequestBlood.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestBlood.ForeColor = System.Drawing.Color.Black;
            this.btnRequestBlood.HoverState.Parent = this.btnRequestBlood;
            this.btnRequestBlood.Image = global::Blood_Bank_Management_System_Layred.Properties.Resources.Exit_application;
            this.btnRequestBlood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequestBlood.Location = new System.Drawing.Point(274, 343);
            this.btnRequestBlood.Name = "btnRequestBlood";
            this.btnRequestBlood.PressedColor = System.Drawing.Color.White;
            this.btnRequestBlood.ShadowDecoration.Parent = this.btnRequestBlood;
            this.btnRequestBlood.Size = new System.Drawing.Size(319, 48);
            this.btnRequestBlood.TabIndex = 129;
            this.btnRequestBlood.Text = "Request Blood";
            this.btnRequestBlood.Click += new System.EventHandler(this.btnRequestBlood_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator2.FillThickness = 3;
            this.guna2Separator2.Location = new System.Drawing.Point(-299, 297);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1228, 10);
            this.guna2Separator2.TabIndex = 128;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator3.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator3.FillThickness = 3;
            this.guna2Separator3.Location = new System.Drawing.Point(-299, -292);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1228, 10);
            this.guna2Separator3.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-180, -376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 105);
            this.label1.TabIndex = 127;
            this.label1.Text = "Stock   Decrease";
            // 
            // HMRequestBloodGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 413);
            this.Controls.Add(this.btnRequestBlood);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Name = "HMRequestBloodGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMRequestBloodGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox txtBloodGroup;
        private System.Windows.Forms.Label lblBloodGroup;
        private Guna.UI2.WinForms.Guna2ComboBox txtUnits;
        private System.Windows.Forms.Label lblUnits;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbltitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnRequestBlood;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label1;
    }
}