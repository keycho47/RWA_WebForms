using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            User user = new User();
            if (Session["uname"] == null)
            {
                lblUsername.Text = " ";
                
            }
            else
            {
                user = (User)Session["uname"];
                lblUsername.Text = user.Firstname;
                btnLogout.Visible = true;
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("Login.aspx");
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            
            if (isAdmin())
            {
                Response.Redirect("AddUser.aspx");
            }
            else
            {
                Response.Write("<script>alert('You are not alowed');</script>");
            }
        }

        private bool isAdmin()
        {
            User u = (User)Session["uname"];

            if (u == null)
            {
                return false;
            }
            else
            {
                if (u.Role == "ADMIN")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        protected void btnUsersList_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsersList.aspx");
        }

        protected void btnEditUsers_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                Response.Redirect("EditUsers.aspx");
            }
            else
            {
                Response.Write("<script>alert('You are not alowed');</script>");
            }
        }

        protected void btnOptions_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                Response.Redirect("Options.aspx");
            }
            else
            {
                Response.Write("<script>alert('You are not alowed');</script>");
            }
        }
    }
}