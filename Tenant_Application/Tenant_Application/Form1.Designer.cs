namespace Tenant_Application
{
    partial class LoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotten = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(108, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 2);
            this.panel2.TabIndex = 0;
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.ForeColor = System.Drawing.Color.White;
            this.tbxUserName.Location = new System.Drawing.Point(108, 69);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(400, 49);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.Text = "Username";
            this.tbxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserName_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Tenant_Application.Properties.Resources.loginPaneObject;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.tbxPassWord);
            this.panel3.Controls.Add(this.pbxPassword);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.btnForgotten);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.tbxUserName);
            this.panel3.Location = new System.Drawing.Point(500, 354);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 441);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.tbxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassWord.Font = new System.Drawing.Font("Calibri", 22F);
            this.tbxPassWord.ForeColor = System.Drawing.Color.White;
            this.tbxPassWord.Location = new System.Drawing.Point(108, 154);
            this.tbxPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.Size = new System.Drawing.Size(400, 45);
            this.tbxPassWord.TabIndex = 1;
            this.tbxPassWord.Text = "Password";
            this.tbxPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassWord_KeyPress);
            // 
            // pbxPassword
            // 
            this.pbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbxPassword.Image = global::Tenant_Application.Properties.Resources.passwordHideWhite;
            this.pbxPassword.Location = new System.Drawing.Point(515, 144);
            this.pbxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(67, 58);
            this.pbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPassword.TabIndex = 54;
            this.pbxPassword.TabStop = false;
            this.pbxPassword.Click += new System.EventHandler(this.pbxPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(108, 220);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 75);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnForgotten
            // 
            this.btnForgotten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnForgotten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnForgotten.FlatAppearance.BorderSize = 0;
            this.btnForgotten.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnForgotten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForgotten.ForeColor = System.Drawing.Color.White;
            this.btnForgotten.Location = new System.Drawing.Point(136, 318);
            this.btnForgotten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForgotten.Name = "btnForgotten";
            this.btnForgotten.Size = new System.Drawing.Size(349, 48);
            this.btnForgotten.TabIndex = 3;
            this.btnForgotten.Text = "Forgotten password";
            this.btnForgotten.UseVisualStyleBackColor = false;
            this.btnForgotten.Click += new System.EventHandler(this.BtnForgotten_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(108, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 2);
            this.panel1.TabIndex = 4;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = global::Tenant_Application.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(261, 14);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(1067, 369);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Tenant_Application.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 838);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotten;
        private System.Windows.Forms.PictureBox pbxPassword;
    }
}
