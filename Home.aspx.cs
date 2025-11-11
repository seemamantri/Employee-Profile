using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Project
{
    public partial class Home : System.Web.UI.Page
    {
        string cs = "Data Source=LAPTOP-CB85HTKQ\\SQLEXPRESS;Initial Catalog=userdb;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            // This checks if someone is logged in
            if (Session["Email"] == null)
            {
                // If not logged in, send back to login page
                Response.Redirect("Login.aspx");
                return;
            }

            // Show the email or name of the logged-in user
            lblUser.Text = "Hello, " + Session["Email"].ToString();
        }

        // When "View Profile" button is clicked
        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx"); // We'll create this page next
        }

        // When "Logout" button is clicked
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear(); // remove login session
            Response.Redirect("Login.aspx"); // go back to login page
        }

    }
}