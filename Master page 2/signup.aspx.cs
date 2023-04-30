using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_page_2
{
    public partial class signup : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saikat\OneDrive\Documents\StudentData.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signup_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert into Student (Name, Address, Branch, Email, Password) values (@Name, @Address, @Branch, @Email, @Password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Address", address.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Branch", branch.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Email", email.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Password", password.Text.ToString().Trim());
            int v = cmd.ExecuteNonQuery();

            if (v > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Registered successfully.." + "');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Something went wrong !!" + "');", true);

            }

            conn.Close();
        }
    }
}