using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Tenant_Application
{
    public partial class UserInterfaceForm : Form
    {
        public UserInterfaceForm()
        {
            InitializeComponent();
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            btnSendMail.BackColor = Color.FromArgb(33, 37, 33);
            this.Width = 1200;
            this.Height = 720;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxComplaint.Text))
            {
                SendMail(tbxComplaint.Text);
            }
            else {
                MessageBox.Show("You need to enter a complaint!");
            }
        }

        private void SendMail(string complaint) {

            tbxComplaint.Clear();


            // ONLY Gmail accounts that have "Use LESS secure apps" ENABLED will work!!!!!
            try
            {
                var fromAddress = new MailAddress("Your email", "Your email name");
                var toAddress = new MailAddress("tenantcomplaints69@gmail.com", "Joseph Stalin");
                const string fromPassword = "Your email password";
                const string subject = "Complaint";
                string body = tbxComplaint.Text;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }


            } catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
