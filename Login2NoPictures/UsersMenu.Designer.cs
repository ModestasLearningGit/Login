
namespace Login2NoPictures
{
    partial class UsersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbIsAdmin = new System.Windows.Forms.ComboBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblAdminStatus);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comment";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(154, 108);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(241, 23);
            this.txtUserID.TabIndex = 7;
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(154, 176);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(241, 23);
            this.txtUserPass.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(154, 241);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(241, 88);
            this.txtComment.TabIndex = 4;
            // 
            // cmbIsAdmin
            // 
            this.cmbIsAdmin.AllowDrop = true;
            this.cmbIsAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsAdmin.FormattingEnabled = true;
            this.cmbIsAdmin.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbIsAdmin.Location = new System.Drawing.Point(154, 206);
            this.cmbIsAdmin.Name = "cmbIsAdmin";
            this.cmbIsAdmin.Size = new System.Drawing.Size(241, 23);
            this.cmbIsAdmin.TabIndex = 3;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(429, 108);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(359, 330);
            this.dgvUsers.TabIndex = 12;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(69, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnADD.Location = new System.Drawing.Point(150, 377);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUPDATE.Location = new System.Drawing.Point(231, 377);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(75, 23);
            this.btnUPDATE.TabIndex = 7;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.Red;
            this.btnDELETE.Location = new System.Drawing.Point(312, 377);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 8;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(154, 142);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(241, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Username";
            // 
            // UsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.cmbIsAdmin);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Menu";
            this.Load += new System.EventHandler(this.UsersMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminStatus;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbIsAdmin;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
    }
}