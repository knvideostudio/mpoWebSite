using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mpoWebSite
{
    public partial class ContactUs : System.Web.UI.Page
    {

        private const string RETURN_EMAIL = "vivian@toastmastersclub5849.org";
        private const string S_URL = "http://www.toastmastersclub5849.org/Default.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string sComment = txtComment.Text;
            string sTemp = "";
            string[] myArr = new string[7];
            string sError = "";


            myArr[0] = txtFirstName.Text;
            myArr[1] = txtLastName.Text;
            myArr[2] = txtCompanyName.Text;
            myArr[3] = txtPhone.Text;
            myArr[4] = txtEmail.Text;

            if (sComment.Length > 500)
            {
                try
                {
                    sTemp = sComment.Substring(0, 499);
                }
                catch (Exception exc)
                {
                    sError = exc.Message;
                    sTemp = "";
                }

            }
            else
            {

                sTemp = sComment;
            }


            myArr[5] = sTemp;

            // addin a new user
            Code.myDatabase.AddNewVisitor(myArr);

            // send an email to client
            SendEmail(txtEmail.Text.Trim());

            string[] myEmails = Code.myCommon.returnSenderEmails();
 
            foreach (string str2 in myEmails)
            {
                SendEmailToUs(myArr, str2);
            }
        }

        private void SendEmailToUs(string[] Arr, string sEmail)
        {
            string sReturn = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("Main Post Office Toastmaster Club 5849 - new e-mail request<br />");
            sb.AppendLine("First Name: " + Arr[0] + ".<br />");
            sb.AppendLine("Last Name: " + Arr[1] + ".<br />");
            sb.AppendLine("Company Name: " + Arr[2] + ".<br />");
            sb.AppendLine("Phone: " + Arr[3] + ".<br />");
            sb.AppendLine("E-mail Address: " + Arr[4] + ".<br />");
            sb.AppendLine("Comment: " + Arr[5] + ".<br />");
            sb.AppendLine(S_URL);
            sb.AppendLine("<br />");
            sb.AppendLine("2012-2014, Toastmaster Club 5849.");

            sReturn = Code.myMessage.SendAnEmail("Toastmaster Club 5849 Club Auto New User", sb, RETURN_EMAIL, sEmail);

            if (sReturn.CompareTo("0") == 0)
            {
                pnlForm.Visible = false;
                lblMessage.Text = "Message has been submitted sucessfully. We will contact you in 2 business days!";
            }
            else
            {
                lblMessage.Text = sReturn;
            }


        }
 

        private void SendEmail(string sEmail)
        {
            string sReturn = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();


            sb.AppendLine("Main Post Office Toastmaster Club 5849<br />");
            sb.AppendLine("Your e-mail is submitted and we will respond to you in 2 business days.<br />");
            sb.AppendLine(S_URL);
            sb.AppendLine("<br />");
            sb.AppendLine("2012, Toastmaster Club 5849.");

            sReturn = Code.myMessage.SendAnEmail("Toastmaster Club 5849 to Client", sb, RETURN_EMAIL, sEmail);

            if (sReturn.CompareTo("0") == 0)
            {
                pnlForm.Visible = false;
                lblMessage.Text = "Message has been submitted sucessfully. We will contact you in 2 business days!";
            }
            else
            {
                lblMessage.Text = sReturn;
            }


        }
    }
}