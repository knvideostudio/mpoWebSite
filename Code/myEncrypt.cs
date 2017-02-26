using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text; 

namespace mpoWebSite.Code
{

    public class myEncrypt
    {

        public myEncrypt() { }


        private const string GUID_APP_KEY = "FEF9FB7E-EF4F-4820-B96A-20414ECE9E72";



        public static string dataDecrypt(string cypherString, bool useHasing)
        {
            myEncrypt de = myEncryptHelper.GetLayer();
            return (de.stringDecrypt(cypherString, useHasing, GUID_APP_KEY));
        }

        private string stringEncrypt(string ToEncrypt, bool useHasing, string Key)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(ToEncrypt);
            
            if (useHasing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(Key);
            }
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = keyArray;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tDes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tDes.Clear();

            return (Convert.ToBase64String(resultArray, 0, resultArray.Length));
        }

        private string stringDecrypt(string cypherString, bool useHasing, string key)
        {
            string sError = string.Empty;

            byte[] keyArray;
            byte[] toDecryptArray = Convert.FromBase64String(cypherString);
           
            if (useHasing)
            {
                MD5CryptoServiceProvider hashmd = new MD5CryptoServiceProvider();
                keyArray = hashmd.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = keyArray;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tDes.CreateDecryptor();

            try
            {
                byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);
                tDes.Clear();

                sError = UTF8Encoding.UTF8.GetString(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return (sError);
        }

    }

    public class myEncryptHelper
    {
        private const string MODULE_NAME = "mpoWebSite.Code.myEncrypt";

        public static myEncrypt GetLayer()
        {
            Type trp = System.Web.Compilation.BuildManager.GetType(MODULE_NAME, true);
            myEncrypt de = (myEncrypt)Activator.CreateInstance(trp);
            return (de);
        }
    }

}