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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(79, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 1);
            this.panel2.TabIndex = 0;
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUserName.ForeColor = System.Drawing.Color.White;
            this.tbxUserName.Location = new System.Drawing.Point(80, 80);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(244, 25);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.Text = "Username";
            this.tbxUserName.Click += new System.EventHandler(this.TbxUserName_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.tbxPassWord);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.tbxUserName);
            this.panel3.Location = new System.Drawing.Point(608, 348);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 369);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(113, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(79, 202);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 1);
            this.panel1.TabIndex = 4;
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tbxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPassWord.ForeColor = System.Drawing.Color.White;
            this.tbxPassWord.Location = new System.Drawing.Point(79, 172);
            this.tbxPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.Size = new System.Drawing.Size(244, 25);
            this.tbxPassWord.TabIndex = 1;
            this.tbxPassWord.Text = "Password";
            this.tbxPassWord.Click += new System.EventHandler(this.TbxPassWord_Click_1);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = global::Tenant_Application.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(268, 14);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(1067, 369);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 838);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}
