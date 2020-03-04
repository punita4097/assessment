using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace q2
{

    /*In this example i have included 
     * ques 1:data provider objects-connection,command,datareader,dataadapter,dataset
     * 
     * Ques2:show different architecture with connection pooling
     * 
     * Ques4: show the difference between the different types of architecture
     * 
     * Ques10: connect the database through the 
     * using keyword in connected architetcure and disconnected architetcure
     * and without using keyword too have been showed
    */
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            try
            {

                using (con = new SqlConnection(ConnectionString))
                    con.ConnectionString ="Data source=.;database=ado_assignment;integrated security=sspi;Connection Timeout=15;Connection Lifetime=0;Min Pool Size=0;Max Pool Size=100;Pooling=true;";
            
                {
                    switch (TextBox1.Text)
                    {
                        case "1":

                           using(SqlConnection connection = new SqlConnection(ConnectionString))
                            {
                                SqlCommand cmd = new SqlCommand("select * from employee;select * from department", connection);
                                connection.Open();
                                SqlDataReader rd = cmd.ExecuteReader();
                                GridView1.DataSource = rd;
                                GridView1.DataBind();
                               
                                while(rd.NextResult())
                                {
                                    GridView2.DataSource = rd;
                                    GridView2.DataBind();

                                }
                              connection.Close();  
                            }
                            break;

                        case "2":

                            using (SqlConnection connection1 = new SqlConnection(ConnectionString))
                            {
                                SqlDataAdapter da = new SqlDataAdapter("select * from department", connection1);

                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                GridView3.DataSource = ds;
                                GridView3.DataBind();
                            }
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                }



            }
            catch (Exception)
            {

                Response.Write("handle the exception");
            }        
            finally
            {
                con.Close();
            }
        
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}