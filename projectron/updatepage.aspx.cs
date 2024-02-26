using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectron
{
    public partial class updatepage : System.Web.UI.Page
    {
        public string globaluname = "";
        public string globalpass = "";
        public string globalemail = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = "Mydatabase.mdf";
            string mysql = "SELECT * FROM MyUsers WHERE usrName = '" + Session["status"].ToString() + "'";
            DataTable table = MyAdoHelper.ExecuteDataTable(filename, mysql);
            int len = table.Rows.Count;

            if (len > 0 )
            {
                globaluname = table.Rows[0]["usrName"].ToString();
                globalpass = table.Rows[0]["usrPass"].ToString();
                globalemail = table.Rows[0]["usrEmail"].ToString();
            }
            if (Request.Form["updateme"]!=null) // אם נלחץ על כפתור העדכון
            {
                string uname = Request.Form["unametoup"].ToString();
                string upass = Request.Form["upasstoup"].ToString();
                string umail = Request.Form["umailtoup"].ToString();
                string selectQuery = "SELECT + FROM MyUsers WHERE usrName" + uname + "'";

                string tablename = "MyUsers";
                string selectQ = "SELECT * FROM MyUsers WHERE usrName='" + uname + "'";
                
                if (!MyAdoHelper.IsExist(filename, selectQ) && Session["status"] == uname)
                {
                    Response.Write("already there!");
                }
                
                else
                {
                    string updateSql = "UPDATE MyUsers SET usrName='" + uname + "', usrPass='" + upass + "', usrEmail='" + umail + "' WHERE usrName='" + Session["status"].ToString() + "'";
                    Session["status"] = uname;
                    MyAdoHelper.DoQuery(filename, updateSql);
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