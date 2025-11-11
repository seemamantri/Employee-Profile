using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Project
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text)||string.IsNullOrWhiteSpace(txtPhone.Text)||string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                //lblMsg.Text = "Please fill all fields before saving!";
                Response.Write("<script>alert('Please fill all fields before saving');</script>");

            }
            if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
            {
                Response.Write("<script>alert('Phone number must be 10 digits only!');</script>");
                return;
            }

            // 3️⃣ Validate email format
            // Must have letters, numbers, special chars, @, and .
            if (!Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                Response.Write("<script>alert('Enter a valid email (must contain @ and .com)!');</script>");
                return;
            }
            using (SqlConnection con = new SqlConnection("data source=LAPTOP-CB85HTKQ\\SQLEXPRESS;initial catalog=userdb;integrated security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertUser",con);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20);
                p1.Value=txtName.Text;
                cmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 15);
                p2.Value = txtPhone.Text;
                cmd.Parameters.Add(p2);


                SqlParameter p3=new SqlParameter("@Email",System.Data.SqlDbType.VarChar, 50);
                p3.Value=txtEmail.Text;
                cmd.Parameters.Add (p3);

                cmd.ExecuteNonQuery();
                con.Close();

                lblMsg.Text = "Record inserted Successfully!";
                Response.Redirect("Login.aspx");

            }
        }
    }
}