using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class command_class : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con= new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select * from employee", con);
                    if (con != null && con.State == ConnectionState.Closed)
                        con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();

                    cmd = new SqlCommand("Select count(*) from employee", con);
                    if (con != null && con.State == ConnectionState.Closed)
                        con.Open();
                    int row = (int)cmd.ExecuteScalar();
                    
                    Response.Write("total rows=" + row.ToString() + "</br>");

                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                  

                  


                  
                }
            }
            catch (Exception)
            {

                Response.Write("handle the exception");
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand command1 = new SqlCommand("insert into employee(id,name,address) values(@id,@name,@address)", con);
                command1.Parameters.AddWithValue("@id", TextBox1.Text);
                command1.Parameters.AddWithValue("@name", TextBox2.Text);
                command1.Parameters.AddWithValue("@address", TextBox3.Text);
                if (con != null && con.State == ConnectionState.Closed)
                    con.Open();
                int row_affected = command1.ExecuteNonQuery();
                Response.Write("Total rows affected" + row_affected.ToString());
            }
        }

    }
}