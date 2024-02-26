using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectron
{
    public partial class LoginForm : System.Web.UI.Page
    {
        public string msg = ""; // global var
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = "Mydatabase.mdf"; // שם הקובץ
            string tablename = "MyUsers";
            msg = Session["status"].ToString();

            if (Request.Form["usub"] != null)
            {
                string username = Request.Form["uname"].ToString();
                string mypass = Request.Form["upass"].ToString();
                string selectQ = "SELECT * FROM " + tablename + " WHERE usrName = '" + username + "' AND usrPass = '" + mypass + "'";

                if (MyAdoHelper.IsExist(filename, selectQ))
                {
                    Session["status"] = username;
                    Session["IsAdmin"] = false;
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    if (IsAdminExists(username, mypass))
                    {
                        Session["status"] = Request.Form["uname"].ToString();
                        Session["IsAdmin"] = true;
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                    {
                        msg = "Username or password is incorrect";
                    }
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