using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectron
{
    public partial class AdminPage : System.Web.UI.Page
    {
        public string WebUsersTable = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["IsAdmin"] == false)
                Response.Redirect("Error_Page.aspx");
            else
            {
                string filename = "Mydatabase.mdf";
                string sqlQ = "SELECT * FROM MyUsers";
                WebUsersTable = MyAdoHelper.printDataTable(filename, sqlQ);
            }

            if (Request.Form["delme"] != null)
            {
                string usertodelete = Request.Form ["delusr"].ToString();
                string filename = "Mydatabase.mdf";
                string sqlExistusrname = "SELECT * From MyUsers where usrName='" + usertodelete + "'";
                if (MyAdoHelper.IsExist(filename, sqlExistusrname))
                {
                    string delQ = "DELETE FROM MyUsers WHERE usrName='" + usertodelete + "'";
                    MyAdoHelper.DoQuery(filename, delQ);
                    Response.Redirect("AdminPage.aspx");
                }
                
            }
        }
    }
}