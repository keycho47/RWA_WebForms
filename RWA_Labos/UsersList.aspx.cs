using RWA_Labos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_Labos
{
    public partial class UsersList : System.Web.UI.Page
    {
        IBaseSelector baseSelector;
        protected void Page_Load(object sender, EventArgs e)
        {
            baseSelector = (IBaseSelector)Session["base"];
            if (!IsPostBack)
            {
                InputDataGrid();
                //InputRepeater();
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

        private void InputDataGrid()
        {
            gvUsers.DataSource = baseSelector.GetAllUsers();
            

            gvUsers.DataBind();
        }

        protected void gvUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvUsers.EditIndex = e.NewEditIndex;            
            InputDataGrid();

        }

        protected void gvUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvUsers.Rows[e.RowIndex];
            int userId = Convert.ToInt32(gvUsers.DataKeys[e.RowIndex].Values[0]);
            string name = (row.FindControl("tbFirstName") as TextBox).Text;
            string lastname = (row.FindControl("tbLastName") as TextBox).Text;
            string phone = (row.FindControl("tbPhone") as TextBox).Text;
            string password = gvUsers.DataKeys[e.RowIndex].Values[1].ToString();
            string city = gvUsers.DataKeys[e.RowIndex].Values[2].ToString();
            string role = (row.FindControl("tbRole") as TextBox).Text;
            string email = (row.FindControl("tbEmail") as TextBox).Text;

            baseSelector.UpdateUser(userId,name,lastname,phone,password,city,role,email);

            gvUsers.EditIndex = -1;
            InputDataGrid();
        }

        protected void gvUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsers.EditIndex = -1;
            InputDataGrid();
        }

        protected void gvUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userID = Convert.ToInt32(gvUsers.DataKeys[e.RowIndex].Values[0]);
            baseSelector.DeleteUser(userID);
            InputDataGrid();
        }

       

        //TODO: Tablica sa repeaterom :
        //private void InputRepeater()
        //{
        //    RepeaterUsersList.DataSource = Repo.RepoText.getAllFromTxt();
        //    RepeaterUsersList.DataBind();
        //}

    }
}