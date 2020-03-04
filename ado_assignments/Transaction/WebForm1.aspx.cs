using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Transaction
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Getdata();
            }
        }

        private void Getdata()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from customer", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                   



                    SqlCommand cmd = new SqlCommand("Update customer set Balance=Balance-100 where Account_number=1001", con, transaction);
                   
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("Update customer set Balance=Balance+100 where Account_number=1002", con, transaction);


                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                    Label1.Text = "transaction Succesful";
                    Label1.ForeColor = System.Drawing.Color.Green;

                }
                catch
                {
                    transaction.Rollback();
                    Label1.Text = "Transaction failed";
                }

                finally
                {
                    Getdata();
                }


            }
        }
    }
}