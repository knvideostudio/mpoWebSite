using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace mpoWebSite.Code
{
    public class myDatabase
    {


        private const string SP_ADD_VISITOR = "spKnToastRequestWebAdd";

        public myDatabase() { }

        public static void AddNewVisitor(string[] arr)
        {
            myDatabase de = myDatabaseHelper.GetLayer();
            de.AddVisit(arr);
        }

        private void AddVisit(string[] sArr)
        {
            string sCoonection = Code.myCommon.ConnectionString();
            string sError = string.Empty;
 
            int i = 0;

            SqlConnection myConn = new SqlConnection(sCoonection);

            myConn.Open();
            SqlCommand cmd = new SqlCommand(SP_ADD_VISITOR, myConn);
            cmd.CommandType =  CommandType.StoredProcedure;

 
            cmd.Parameters.Add("@COMP_NAME", SqlDbType.VarChar).Value = sArr[2];
            cmd.Parameters.Add("@FIRST_NAME", SqlDbType.VarChar).Value = sArr[0];
            cmd.Parameters.Add("@LAST_NAME", SqlDbType.VarChar).Value = sArr[1];
            cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@ADDRESS_CONT", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CITY", SqlDbType.VarChar).Value = "";
	        cmd.Parameters.Add("@STATE", SqlDbType.VarChar).Value = "GA";
            cmd.Parameters.Add("@ZIP", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@PHONE_NUMBER", SqlDbType.VarChar).Value = sArr[3];
            cmd.Parameters.Add("@FAX_NUMBER", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@EMAIL_ADDR", SqlDbType.VarChar).Value = sArr[4];
            cmd.Parameters.Add("@COMMENT", SqlDbType.VarChar).Value = sArr[5];
            cmd.Parameters.Add("@CLUB_NUM", SqlDbType.VarChar).Value = "5849";

            try
            {
               i = cmd.ExecuteNonQuery(); 
            }
            catch (Exception exc)
            {
                sError = exc.Message;
            }
            finally
            {
                myConn.Close();
                myConn.Dispose(); 
            }

//DBCmd.ExecuteNonQuery()
//Response.Write("Your Record is Updated ")


        }
    }

    public class myDatabaseHelper
    {
        private const string MODULE_NAME = "mpoWebSite.Code.myDatabase";

        public static myDatabase GetLayer()
        {
            Type trp = System.Web.Compilation.BuildManager.GetType(MODULE_NAME, true);
            myDatabase de = (myDatabase)Activator.CreateInstance(trp);
            return (de);
        }
    }
}