﻿
namespace Login2NoPictures
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUsersMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblAdminStatus);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 1;
            // 
            // lblAdminStatus
            // 
            this.lblAdminStatus.AutoSize = true;
            this.lblAdminStatus.Location = new System.Drawing.Point(119, 33);
            this.lblAdminStatus.Name = "lblAdminStatus";
            this.lblAdminStatus.Size = new System.Drawing.Size(0, 15);
            this.lblAdminStatus.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(119, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 15);
            this.lblUsername.TabIndex = 3;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(4, 33);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(111, 15);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Have Admin Status:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Logged In As:";
            // 
            // btnUsersMenu
            // 
            this.btnUsersMenu.Location = new System.Drawing.Point(34, 117);
            this.btnUsersMenu.Name = "btnUsersMenu";
            this.btnUsersMenu.Size = new System.Drawing.Size(103, 56);
            this.btnUsersMenu.TabIndex = 2;
            this.btnUsersMenu.Text = "Users Menu";
            this.btnUsersMenu.UseVisualStyleBackColor = true;
            this.btnUsersMenu.Click += new System.EventHandler(this.btnUsersMenu_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsersMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminStatus;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUsersMenu;
    }
}