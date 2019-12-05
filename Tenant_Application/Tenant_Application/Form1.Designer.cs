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
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new Client_GUI.Round_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassWord.Location = new System.Drawing.Point(6, 119);
            this.tbxPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.Size = new System.Drawing.Size(50, 13);
            this.tbxPassWord.TabIndex = 1;
            this.tbxPassWord.Click += new System.EventHandler(this.TbxPassWord_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(126, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 52);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(378, 262);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 52);
            this.panel1.TabIndex = 2;
            // 
            // tbxUserName
            // 
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(22, 268);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(50, 19);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.Click += new System.EventHandler(this.TbxUserName_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(178, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 88);
            this.panel3.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(156, -32);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(348, 126);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(296, 253);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(38, 12);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "round_Button1";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 337);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxPassWord);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Panel panel3;
        private Client_GUI.Round_Button btnLogIn;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}
