﻿namespace Tenant_Application
{
    partial class ModifyForm
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
            this.lblStatusName = new System.Windows.Forms.Label();
            this.lblStatusEmail = new System.Windows.Forms.Label();
            this.lblStatusPassword = new System.Windows.Forms.Label();
            this.lblStatusUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRegMain = new System.Windows.Forms.Label();
            this.tbxRegName = new System.Windows.Forms.TextBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.tbxRegEmail = new System.Windows.Forms.TextBox();
            this.tbxRegUsername = new System.Windows.Forms.TextBox();
            this.tbxRegPassword = new System.Windows.Forms.TextBox();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusName.ForeColor = System.Drawing.Color.White;
            this.lblStatusName.Location = new System.Drawing.Point(589, 306);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(136, 25);
            this.lblStatusName.TabIndex = 48;
            this.lblStatusName.Text = "Name is taken";
            this.lblStatusName.Visible = false;
            // 
            // lblStatusEmail
            // 
            this.lblStatusEmail.AutoSize = true;
            this.lblStatusEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusEmail.ForeColor = System.Drawing.Color.White;
            this.lblStatusEmail.Location = new System.Drawing.Point(589, 254);
            this.lblStatusEmail.Name = "lblStatusEmail";
            this.lblStatusEmail.Size = new System.Drawing.Size(132, 25);
            this.lblStatusEmail.TabIndex = 47;
            this.lblStatusEmail.Text = "Email is taken";
            this.lblStatusEmail.Visible = false;
            // 
            // lblStatusPassword
            // 
            this.lblStatusPassword.AutoSize = true;
            this.lblStatusPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusPassword.ForeColor = System.Drawing.Color.White;
            this.lblStatusPassword.Location = new System.Drawing.Point(631, 194);
            this.lblStatusPassword.Name = "lblStatusPassword";
            this.lblStatusPassword.Size = new System.Drawing.Size(170, 25);
            this.lblStatusPassword.TabIndex = 46;
            this.lblStatusPassword.Text = "Password is taken";
            this.lblStatusPassword.Visible = false;
            // 
            // lblStatusUsername
            // 
            this.lblStatusUsername.AutoSize = true;
            this.lblStatusUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusUsername.ForeColor = System.Drawing.Color.White;
            this.lblStatusUsername.Location = new System.Drawing.Point(589, 137);
            this.lblStatusUsername.Name = "lblStatusUsername";
            this.lblStatusUsername.Size = new System.Drawing.Size(174, 25);
            this.lblStatusUsername.TabIndex = 45;
            this.lblStatusUsername.Text = "Username is taken";
            this.lblStatusUsername.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "Choose a name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(17, 247);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(228, 32);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Choose an email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(17, 188);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(264, 32);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Choose a password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(17, 130);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(269, 32);
            this.lblUsername.TabIndex = 41;
            this.lblUsername.Text = "Choose a username";
            // 
            // lblRegMain
            // 
            this.lblRegMain.AutoSize = true;
            this.lblRegMain.BackColor = System.Drawing.Color.Transparent;
            this.lblRegMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegMain.ForeColor = System.Drawing.Color.White;
            this.lblRegMain.Location = new System.Drawing.Point(24, 27);
            this.lblRegMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegMain.Name = "lblRegMain";
            this.lblRegMain.Size = new System.Drawing.Size(338, 54);
            this.lblRegMain.TabIndex = 40;
            this.lblRegMain.Text = "Modify account";
            // 
            // tbxRegName
            // 
            this.tbxRegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRegName.Location = new System.Drawing.Point(293, 306);
            this.tbxRegName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRegName.Name = "tbxRegName";
            this.tbxRegName.Size = new System.Drawing.Size(289, 30);
            this.tbxRegName.TabIndex = 38;
            this.tbxRegName.TextChanged += new System.EventHandler(this.TbxRegName_TextChanged);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(66)))), ((int)(((byte)(120)))));
            this.btnCreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcc.Location = new System.Drawing.Point(29, 379);
            this.btnCreateAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(257, 68);
            this.btnCreateAcc.TabIndex = 39;
            this.btnCreateAcc.Text = "Modify Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.BtnCreateAcc_Click);
            // 
            // tbxRegEmail
            // 
            this.tbxRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRegEmail.Location = new System.Drawing.Point(293, 250);
            this.tbxRegEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRegEmail.Name = "tbxRegEmail";
            this.tbxRegEmail.Size = new System.Drawing.Size(289, 30);
            this.tbxRegEmail.TabIndex = 37;
            this.tbxRegEmail.TextChanged += new System.EventHandler(this.TbxRegEmail_TextChanged);
            // 
            // tbxRegUsername
            // 
            this.tbxRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRegUsername.Location = new System.Drawing.Point(293, 134);
            this.tbxRegUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRegUsername.Name = "tbxRegUsername";
            this.tbxRegUsername.Size = new System.Drawing.Size(289, 30);
            this.tbxRegUsername.TabIndex = 35;
            this.tbxRegUsername.TextChanged += new System.EventHandler(this.TbxRegUsername_TextChanged);
            // 
            // tbxRegPassword
            // 
            this.tbxRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRegPassword.Location = new System.Drawing.Point(293, 191);
            this.tbxRegPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRegPassword.Name = "tbxRegPassword";
            this.tbxRegPassword.Size = new System.Drawing.Size(289, 30);
            this.tbxRegPassword.TabIndex = 36;
            this.tbxRegPassword.TextChanged += new System.EventHandler(this.TbxRegPassword_TextChanged);
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxAdmin.ForeColor = System.Drawing.Color.White;
            this.cbxAdmin.Location = new System.Drawing.Point(640, 399);
            this.cbxAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(184, 29);
            this.cbxAdmin.TabIndex = 52;
            this.cbxAdmin.Text = "Landlord account";
            this.cbxAdmin.UseVisualStyleBackColor = false;
            // 
            // pbxPassword
            // 
            this.pbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbxPassword.Image = global::Tenant_Application.Properties.Resources.passwordHideWhite;
            this.pbxPassword.Location = new System.Drawing.Point(584, 188);
            this.pbxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(40, 37);
            this.pbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPassword.TabIndex = 53;
            this.pbxPassword.TabStop = false;
            this.pbxPassword.Click += new System.EventHandler(this.pbxPassword_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tenant_Application.Properties.Resources.panelobject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 478);
            this.Controls.Add(this.pbxPassword);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.lblStatusName);
            this.Controls.Add(this.lblStatusEmail);
            this.Controls.Add(this.lblStatusPassword);
            this.Controls.Add(this.lblStatusUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRegMain);
            this.Controls.Add(this.tbxRegName);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.tbxRegEmail);
            this.Controls.Add(this.tbxRegUsername);
            this.Controls.Add(this.tbxRegPassword);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusName;
        private System.Windows.Forms.Label lblStatusEmail;
        private System.Windows.Forms.Label lblStatusPassword;
        private System.Windows.Forms.Label lblStatusUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRegMain;
        private System.Windows.Forms.TextBox tbxRegName;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.TextBox tbxRegEmail;
        private System.Windows.Forms.TextBox tbxRegUsername;
        private System.Windows.Forms.TextBox tbxRegPassword;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.PictureBox pbxPassword;
    }
}