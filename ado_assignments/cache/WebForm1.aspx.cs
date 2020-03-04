using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/*Cache is a small amount of memory which is a part of the CPU - closer to the CPU than RAM .
It is used to temporarily hold instructions and data that the CPU is likely to reuse.

There is a number of banefits of using cache :
1.avoid network congestion
2.content availability
3.reduce latencys
*/

namespace cache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnloaddata_Click(object sender, EventArgs e)
        {   if (Cache["Data"] == null)
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;
                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                }

                Lblmessage.Text = "Data loaded from the database";
            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["Data"];
                GridView1.DataBind();

                Lblmessage.Text = "data loaded from the cache";
            }
        }

        protected void Btnclearcache_Click(object sender, EventArgs e)
        {
            if(Cache["Data"]!=null)
            {
                Cache.Remove("Data");
                Lblmessage.Text = "The dataset is removed from the cache";
            }
            else
            {
                Lblmessage.Text = "There is nothing to remove";
            }
        }
    }
}