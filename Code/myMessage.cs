using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace mpoWebSite.Code
{
    public class myMessage
    {

        private const string RETURN_EMAIL = "vivian@toastmastersclub5849.org";
        private const string POST_EMAIL_ADDR = "postmaster@toastmastersclub5849.org";
        private const string POST_PWD = "Jk9Alerbo7";
        private const string POST_SMTP_HOST = "mail.toastmastersclub5849.org";

        public myMessage() { }

        public static string SendAnEmail(string sMySubject, System.Text.StringBuilder body, string sFromSender, string sRecipient)
        {
            myMessage se = myMessageHelper.GetLayer();
            return (se.SendEmail(sMySubject, body, sFromSender, sRecipient));
        }

        private string SendEmail(string sMySubject, System.Text.StringBuilder body, string sFromSender, string sRecipient)
        {
            MailMessage myMessage = new MailMessage();
            MailAddress maFrom = new MailAddress(sFromSender);
            MailAddress maTo = new MailAddress(sRecipient);
            string sTemp = "0";

            myMessage.To.Add(maTo);
            myMessage.From = maFrom;
            myMessage.Priority = MailPriority.High;
            myMessage.IsBodyHtml = true;
            myMessage.Subject = sMySubject;
            myMessage.BodyEncoding = System.Text.Encoding.Default;
  
            myMessage.Body = body.ToString();

            SmtpClient smtCle = new SmtpClient();
            System.Net.NetworkCredential basicAuthenUser = new System.Net.NetworkCredential(POST_EMAIL_ADDR, POST_PWD);

            try
            {

                smtCle.Host = POST_SMTP_HOST;
                smtCle.UseDefaultCredentials = false;
                smtCle.Credentials = basicAuthenUser;

                //SmtpClient client = new SmtpClient("mail.toastmastersclub5849.org");
                //client.Port = 25;
                smtCle.Send(myMessage);
            }
            catch (System.Exception ex)
            {
                sTemp = ex.Source.ToString() + ex.Message.ToString();
            }
            finally
            {
                if (myMessage != null) myMessage = null;
            }

            return (sTemp);
        }

    }


    public class myMessageHelper
    {
        private const string MODULE_NAME = "mpoWebSite.Code.myMessage";

        public static myMessage GetLayer()
        {
            Type trp = System.Web.Compilation.BuildManager.GetType(MODULE_NAME, true);
            myMessage de = (myMessage)Activator.CreateInstance(trp);
            return (de);
        }
    }

}