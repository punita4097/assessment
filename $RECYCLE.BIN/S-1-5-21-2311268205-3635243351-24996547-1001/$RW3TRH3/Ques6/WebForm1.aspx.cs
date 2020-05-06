using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }
                TextBox1.Text = ViewState["Clicks"].ToString();
            

            
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox2.Text = Session["Clicks"].ToString();



                if (Application["Clicks"] == null)
                {
                    Application["Clicks"] = 0;
                }
                TextBox3.Text = Application["Clicks"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ClicksCount = (int)ViewState["Clicks"] + 1;
            TextBox1.Text = ClicksCount.ToString();
            ViewState["Clicks"] = ClicksCount;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int ClicksCount1 = (int)Session["Clicks"] + 1;
            TextBox2.Text = ClicksCount1.ToString();
            Session["Clicks"] = ClicksCount1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int ClicksCount2 = (int)Application["Clicks"] + 1;
            TextBox3.Text = ClicksCount2.ToString();
            Application["Clicks"] = ClicksCount2;
        }
    }
}