using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace Demoapp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
        if(!IsPostBack)
            {
                /* ListItem mlist = new ListItem("male", "1");
                 ListItem flist = new ListItem("female", "0");
                 //ListItem mlist = new ListItem("male", "1");

                 DropDownList1.Items.Add(mlist);

                 DropDownList1.Items.Add(flist);*/

                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("country.xml"));
                DropDownList1.DataTextField = "CountryName";
                DropDownList1.DataValueField = "CountryId";
                DropDownList1.DataSource = ds;
                DropDownList1.DataBind();
                ListItem li = new ListItem("select","-1");
                DropDownList1.Items.Insert(0, li);

              //  DropDownList1.
                


            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userdetails");

            cookie["name"]


            Response.Redirect("WebForm2.aspx?UserName=" + Server.UrlEncode(TextBox1.Text));
                

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}