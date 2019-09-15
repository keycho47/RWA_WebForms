using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class Options : System.Web.UI.Page
    {
        IBaseSelector baseSelector;
        protected void Page_Load(object sender, EventArgs e)
        {
            baseSelector = (IBaseSelector)Session["base"];
            if (!IsPostBack)
            {
                fillDDLs();
            }
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

        private void fillDDLs()
        {
            ddlLang.Items.Add(new ListItem("--- Chose ---"));
  
            ddlTeme.Items.Add(new ListItem("--- Chose ---"));

            ddlRepo.Items.Add(new ListItem("--- Chose ---"));
            ddlRepo.Items.Add(new ListItem("DB", "DB"));
            ddlRepo.Items.Add(new ListItem("TXT", "TXT"));
        }

        protected void ddlRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlRepo.SelectedValue == "DB")
            {
                Session["base"] = new RepoDB();
                LogOut();
            }
            else if (ddlRepo.SelectedValue == "TXT")
            {
                Session["base"] = new RepoText();
                LogOut();

            }
        }

        private void LogOut()
        {
            Session["uname"] = null;
            Response.BufferOutput = true;
            Response.Redirect("Login.aspx");
        }
    }
}