using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration; 

namespace mpoWebSite.Code
{
    public class myCommon
    {


        public myCommon() { }

        public static string ConnectionString()
        {
            myCommon de = myCommonHelper.GetLayer();
            return (de.GetConnection);
        }

        public static string[] returnSenderEmails()
        {
            string[] myArr = null;
            Char myChar = Char.Parse(";");
            string str = string.Empty;
 
            myCommon de = myCommonHelper.GetLayer();
            str = de.GetSenderEmails;
            myArr = str.Split(myChar);

            return (myArr);
        }

        private string GetSenderEmails
        {
            get
            {
                string str = ConfigurationManager.AppSettings["DefaultSenderEmails"].ToString();
                return (str);
            }
        }

        private string GetConnection
        {
            get
            {
                string strEnc = ConfigurationManager.ConnectionStrings["DB:mpoDevEnc"].ConnectionString;
                string str = Code.myEncrypt.dataDecrypt(strEnc, true);

                return (str);
            }
        }
    }

    public class myCommonHelper
    {
        private const string MODULE_NAME = "mpoWebSite.Code.myCommon";

        public static myCommon GetLayer()
        {
            Type trp = System.Web.Compilation.BuildManager.GetType(MODULE_NAME, true);
            myCommon de = (myCommon)Activator.CreateInstance(trp);
            return (de);
        }
    }

}