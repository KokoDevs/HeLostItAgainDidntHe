using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectron
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["usub"]  != null) // אם נלחץ על כפתור הירשם
            {
                string filename = "Mydatabase.mdf";// השם של הדטה בייס למשתנה
                string tableName = "MyUsers";// השם של הטבלה למשתנה
                string usrname = Request.Form["uname"];// מה שרשום בשם משתמש
                string userpass = Request.Form["upass"];// מה שרשום בסיסמה
                string usermail = Request.Form["email"];//מה שרשום באימייל
                string usrGender = Request.Form["ugender"];//מה שקולט את המין
                

                string selectQuery;
                selectQuery = "SELECT * FROM MyUsers WHERE usrName = '" + usrname + "'";
                if (MyAdoHelper.IsExist(filename, selectQuery))
                {
                    Response.Write("User already exists!");
                    Response.End();
                    
                }
                else if (IsAdminExists(usrname, userpass))
                {
                    Response.Write("User already exists!");
                    Response.End();
                }
                else
                {
                    string sqlCommand = "INSERT INTO " + tableName + "(usrName, usrPass, usrEmail, usrGender) VALUES ('" + usrname + "','" + userpass + "','" + usermail + "','" + usrGender + "')";
                    MyAdoHelper.DoQuery(filename, sqlCommand);
                    Response.Write("insert complete...");
                    Response.Redirect("HomePage.aspx");
                }
                
            }
        }
        public static bool IsAdminExists(string user, string password)
        {
            bool flag = false;
            DataSet ds = new DataSet();
            ds.ReadXml(System.Web.HttpContext.Current.Server.MapPath("MyXml.xml"));
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                if ((user == (r[0].ToString())) && (password == (r[1].ToString())))
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}