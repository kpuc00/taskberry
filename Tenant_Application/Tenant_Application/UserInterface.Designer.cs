namespace Tenant_Application
{
    partial class UserInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceForm));
            this.tabEmailComplaint = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxComplaint = new System.Windows.Forms.RichTextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEmailComplaint.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmailComplaint
            // 
            this.tabEmailComplaint.Controls.Add(this.tabPage1);
            this.tabEmailComplaint.Controls.Add(this.tabPage2);
            this.tabEmailComplaint.Location = new System.Drawing.Point(12, 12);
            this.tabEmailComplaint.Name = "tabEmailComplaint";
            this.tabEmailComplaint.SelectedIndex = 0;
            this.tabEmailComplaint.Size = new System.Drawing.Size(1150, 625);
            this.tabEmailComplaint.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbxComplaint);
            this.tabPage2.Controls.Add(this.btnSendMail);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1134, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxComplaint
            // 
            this.tbxComplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxComplaint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComplaint.Location = new System.Drawing.Point(202, 145);
            this.tbxComplaint.Name = "tbxComplaint";
            this.tbxComplaint.Size = new System.Drawing.Size(710, 200);
            this.tbxComplaint.TabIndex = 1;
            this.tbxComplaint.Text = "";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.White;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(349, 439);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(400, 100);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "btnSendMail";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your complaint down below and press send";
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.tabEmailComplaint);
            this.Name = "UserInterfaceForm";
            this.Text = "UserInterfaceForm";
            this.Load += new System.EventHandler(this.UserInterfaceForm_Load);
            this.tabEmailComplaint.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmailComplaint;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.RichTextBox tbxComplaint;
        private System.Windows.Forms.Label label1;
    }
}