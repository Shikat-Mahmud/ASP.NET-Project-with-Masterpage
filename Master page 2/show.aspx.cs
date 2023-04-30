using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_page_2
{
    public partial class show : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saikat\OneDrive\Documents\StudentData.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
                { 
                    string query = "Select Id, Name, Address, Branch, Email from Student";
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    col_repeater.DataSource = dt;
                    col_repeater.DataBind();
                
                }
            }

        
        protected void col_repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "delete")
                {
                    conn.Open();
                    string query = "Delete from Student where Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", e.CommandArgument);
                    int v = cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("~/show.aspx");
                }
                if (e.CommandName == "edit")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Student where Id=@userId", conn);
                    cmd.Parameters.AddWithValue("@userId", e.CommandArgument.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Session["Id_Update"] = reader["Id"].ToString();
                        Session["Name"] = reader["Name"].ToString();
                        Session["Address"] = reader["Address"].ToString();
                        Session["Branch"] = reader["Branch"].ToString();
                        Session["Email"] = reader["Email"].ToString();
                        reader.Close();
                        conn.Close();
                        Response.Redirect("~/edit.aspx");

                    }
                }

            }catch (Exception)
            {

                Response.Write("<script LANGUAGE='JavaScript' >alert('Something went wrong !!!.')</script>");
            }
        }

    }
}