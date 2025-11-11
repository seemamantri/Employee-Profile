using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Project
{
    public partial class Profile : System.Web.UI.Page
    {
        string cs = "Data Source=LAPTOP-CB85HTKQ\\SQLEXPRESS;Initial Catalog=userdb;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Protect page from direct access
            if (Session["Email"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadProfile();
            }

        }
        private void LoadProfile()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_GetUserProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Email", Session["Email"].ToString());
                
              
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblName.Text = dr["Name"].ToString();
                    lblPhone.Text = dr["Phone"].ToString();
                    lblEmail.Text = dr["Email"].ToString();


                }
                con.Close();
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}