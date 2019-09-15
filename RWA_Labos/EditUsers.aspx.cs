using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class EditUsers : System.Web.UI.Page
    {
        IBaseSelector baseSelector;
        //EditUserControl editUserControl = new EditUserControl();
        protected void Page_Load(object sender, EventArgs e)
        {
            baseSelector = (IBaseSelector)Session["base"];
            User user = new User();
            if (Session["uname"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                user = (User)Session["uname"];
            }



            List<User> users = baseSelector.GetAllUsers();

            lvEditUsers.DataSource = users;
            lvEditUsers.DataBind();


            //EditUserControl.ButtonEditClick += new EventHandler(UserControl_ButtonClick);
        }

        

        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {
            //handle the event 
        }
    }
}