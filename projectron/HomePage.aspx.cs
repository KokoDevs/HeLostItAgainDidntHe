using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectron
{
    public partial class HomePage : System.Web.UI.Page
    {
        public string usersta = ""; // גלובלי כדי לשתול בצד הלקוח
        public string adminPanel = "";
        public string disconect = "";
        public string register = "<a href =\"SubmitPage.aspx\" class=\"button\"> To register </a> ";
        public string login = "<a href =\"LoginForm.aspx\" class=\"button\"> To login </a> ";
        public string update = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["status"] == null) // אם הסשן לא נוצר עדיין
            {
                Session["status"] = "guest";
                Session["IsAdmin"] = false;
            }
            usersta = Session["status"].ToString();

            if (Session["status"] != "guest") 
            {
                register = "";
                login = "";
                disconect = "<a href =\"disconect.aspx\" class=\"button\"> To log out </a> ";
                update = "<a href =\"updatepage.aspx\" class=\"button\"> To update </a> ";
            }

            if ((bool)Session["IsAdmin"] == true)
            {
                adminPanel = "<a href =\"AdminPage.aspx\" class=\"button\"> Admin page </a> ";
            }


        }
    }
}