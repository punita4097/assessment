using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ClickCount = 0;
        int ClickCount1 = 0;
        int ClickCount2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }
                TextBox1.Text = ViewState["Clicks"].ToString();


                if (Session["Clicks1"] == null)
                {
                    Session["Clicks1"] = 0;
                }
                TextBox2.Text = Session["Clicks1"].ToString();


                if (Application["Clicks2"] == null)
                {
                    Application["Clicks2"] = 0;
                }
                TextBox3.Text = Application["Clicks2"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("no of application running: " + Application["TotalApplications"]);
            Response.Write("no of session running: " + Application["TotalUserSessions"]);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            int ClicksCount = (int)ViewState["Clicks"] + 1;
            TextBox1.Text = ClicksCount.ToString();
            ViewState["Clicks"] = ClicksCount;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int ClicksCount1 = (int)Session["Clicks1"] + 1;
            TextBox2.Text = ClicksCount1.ToString();
            Session["Clicks1"] = ClicksCount1;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            int ClicksCount2 = (int)Application["Clicks2"] + 1;
            TextBox3.Text = ClicksCount2.ToString();
            Application["Clicks2"] = ClicksCount2;
        }
    }
}