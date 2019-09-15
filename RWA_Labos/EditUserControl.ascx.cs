using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class EditUserControl : System.Web.UI.UserControl
    {
        public event EventHandler ButtonEditClick;
        public event EventHandler ButtonDeleteClick;
      

        public User user { get; set; }
        IBaseSelector baseSelector;

        protected void Page_Load(object sender, EventArgs e)
        {
            baseSelector = (IBaseSelector)Session["base"];
            if (!IsPostBack)
            {
                fillDdList();
            }
            
        }

        private void fillDdList()
        {
            foreach (ListItem item in ddlCity.Items)
            {
                if (user.City == item.Value)
                {
                    ddlCity.SelectedValue = item.Value;
                }
            }
            foreach (ListItem item in ddlRole.Items)
            {
                if (user.Role == item.Value)
                {
                    ddlRole.SelectedValue = item.Value;
                }
            }
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.ButtonEditClick != null)
                this.ButtonEditClick(this, e);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.ButtonDeleteClick != null)
                this.ButtonDeleteClick(this, e);
        }




    }
}