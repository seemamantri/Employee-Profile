using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Employee_Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEmail.Text)||string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblMsg.Text = "Please Enter All Fields!";


            }
            using(SqlConnection con = new SqlConnection("data source=LAPTOP-CB85HTKQ\\SQLEXPRESS;initial catalog=userdb;integrated security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1=new SqlParameter("@Email",SqlDbType.NVarChar,20);
                p1.Value = txtEmail.Text;

                SqlParameter p2 = new SqlParameter("@Phone", SqlDbType.NVarChar, 15);
                p2.Value = txtPhone.Text;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.ExecuteNonQuery();

                int count=Convert.ToInt32(cmd.ExecuteScalar());
                if(count>0)
                {
                    //lblMsg.ForeColor = System.Drawing.Color.Green;
                    //lblMsg.Text = "Login Successfull! Welcome";
                    Session["Email"] = txtEmail.Text;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = "Invalid Email or Phone!";
                }
                con.Close();
            }
        }
    }
}