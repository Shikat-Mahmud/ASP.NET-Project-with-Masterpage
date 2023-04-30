using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_page_2
{
    public partial class edit : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saikat\OneDrive\Documents\StudentData.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Email"] != null && Session["Branch"] != null && Session["Address"] != null && Session["Name"] != null && Session["Id_Update"]!= null)
                {
                    UpdateUI();
                } else {
                    Response.Redirect("~/login.aspx");
                }
                    
                
            }
        }

        private void UpdateUI()
        {
            name.Text = Session["Name"].ToString();
            address.Text = Session["Address"].ToString();
            branch.Text = Session["Branch"].ToString();
            email.Text = Session["Email"].ToString();
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Update Student set Name=@Name, Address=@Address, Branch=@Branch, Email=@Email where Id=@Id ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", Session["Id_Update"].ToString().Trim());
            cmd.Parameters.AddWithValue("@Name", name.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Address", address.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Branch", branch.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Email", email.Text.ToString().Trim());
            int v = cmd.ExecuteNonQuery();
            if (v > 0)
            {
                conn.Close();
                Response.Redirect("~/show.aspx");
            }
            else
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Something went wrong !!" + "');", true);

            }

            
        }
    }
}
