using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class Login : System.Web.UI.Page
    {
        IBaseSelector baseSelector;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["base"] == null)
            {
               
                Session["base"] = new RepoText(); 
            }
            baseSelector = (IBaseSelector)Session["base"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin();                     
        }

        private void checkLogin()
        {           
            List<User> useri = baseSelector.GetAllUsers();

            User u = (User)useri.Where(x => x.Firstname == tbUsename.Text).FirstOrDefault();
            if (u == null)
            {
                lblInfo.Text = "No user with this password";
            }
            else
            {
                if (u.Firstname == tbUsename.Text && u.Password == tbPassword.Text)
                {
                    Session["uname"] = u;
                    Response.BufferOutput = true;
                    Response.Redirect("UsersList.aspx");
                }
                else
                {
                    lblInfo.Text = "No user with this password";
                }
            }
            
            

            

        }
    }
}