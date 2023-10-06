using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace EnviarCorreo.WebApp.NetFramework
{
    public class EmailTools
    {
        #region Methods

        public static bool SendEmail(string emailOrigin, string emailDestinatary, string subject, string body)
        {
            MailMessage mailMessage = CreateMessage(new MailAddress(emailOrigin), emailDestinatary, subject, body);
            return SendClientMail(mailMessage);
        }

        public static MailMessage CreateMessage(MailAddress from, string to, string subject, string body)
        {
            MailMessage mailMessage = new MailMessage()
            {
                From = from,
                Subject = subject,
                Body = body
            };

            mailMessage.To.Add(to);

            return mailMessage;
        }


        public static bool SendClientMail(MailMessage mailMessage)
        {
            bool success = false;

            try
            {
                SmtpClient client = CreateClient();
                client.Send(mailMessage);

                success = true;
            }
            catch (Exception exception) { }

            return success;
        }

        public static SmtpClient CreateClient()
        {
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Host = "webmail.uag.mx";
            client.Port = 25;
            client.EnableSsl = false;
            client.Credentials = new System.Net.NetworkCredential("campus.digital@webmail.uag.mx", "Sistemas19");

            return client;
        }

        #endregion
    }
}