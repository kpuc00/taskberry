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

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("email-address from");
                mail.To.Add("email-address to ");
                mail.Subject = "Tenant Complaint";
                mail.Body = complaint;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("email-address from", "password");
                SmtpServer.Send(mail);

                MessageBox.Show("Mail Sent");
            } catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
