using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_page_2
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saikat\OneDrive\Documents\StudentData.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Select * from Student where Email=@Email and Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@Password", password.Text.ToString().Trim());

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session["email"] = reader["Email"].ToString();
                    Session["user_id"] = reader["Id"].ToString();
                    reader.Close();
                    conn.Close();
                    Response.Redirect("~/Home.aspx");
                }
                else
                {
                    Session["email"] = null;
                    Session["user_id"] = null;
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Invalid Credentials !!" + "');", true);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
    }
}
