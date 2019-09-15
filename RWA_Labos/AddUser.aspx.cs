using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class Home1 : System.Web.UI.Page
    {
        IBaseSelector baseSelector;
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
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            baseSelector.AddUser(tbAddName.Text,tbAddLastName.Text,tbAddPhone.Text,tbAddPassword.Text,ddlCity.SelectedValue,ddlRole.SelectedValue,tbAddEmail.Text);
        }
    }
}