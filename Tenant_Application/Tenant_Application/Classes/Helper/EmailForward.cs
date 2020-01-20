using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Tenant_Application
{
    public static class EmailForward
    {
        public static string SendMail(string complaint, string subject, string successful)
        {
            // ONLY Gmail accounts that have "Use LESS secure apps" ENABLED will work!!!!!
            try
            {
                var fromAddress = new MailAddress("complaintfromtenant@gmail.com");
                var toAddress = new MailAddress("tenantcomplaints69@gmail.com", "Joseph Stalin");
                string fromPassword = "Complaint_123";
                string body = complaint;

                SmtpClient smtp = GetSmtpClient(fromAddress, fromPassword);
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                return successful;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string SendRecovery(string personEmail, string recoveryData, string subject, string successful)
        {
            // ONLY Gmail accounts that have "Use LESS secure apps" ENABLED will work!!!!!
            try
            {
                var fromAddress = new MailAddress("tenantcomplaints69@gmail.com");
                var toAddress = new MailAddress(personEmail);
                string fromPassword = "RealCommunism69";
                string body = recoveryData;

                var smtp = GetSmtpClient(fromAddress, fromPassword);
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                return successful;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string SendAnnToEveryMail(List<string> personEmail, string announcement, string subject, string successful)
        {
            try {
                for (int i = 0; i < personEmail.Count; i++)
                {
                    var fromAddress = new MailAddress("tenantcomplaints69@gmail.com");
                    var toAddress = new MailAddress(personEmail[i]);
                    string fromPassword = "RealCommunism69";
                    string body = announcement;

                    var smtp = GetSmtpClient(fromAddress, fromPassword);
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {

                        smtp.Send(message);
                    }
                }
                return successful;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private static SmtpClient GetSmtpClient(MailAddress fromAddress, string fromPassword)
        {
            return new SmtpClient()
            {
                //Don't change these settings
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

        }

    }
}
