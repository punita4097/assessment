using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("only click event fire");
        }

        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "button2":
                    Label1.Text = "click first command button";
                    break;
                case "button3":
                    Label2.Text = "click second command button";
                    break;
                default:
                    break;
            }
        }

     
    }
}