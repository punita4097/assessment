using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Ques 4 :

namespace Ispostback
{
    public partial class ispostback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
                Loadcity();
            }

        }

        public void Loadcity()
        {
            ListItem li1 = new ListItem("Select");
            List1.Items.Add(li1);

            ListItem li2 = new ListItem("Faridabad");
            List1.Items.Add(li2);

            ListItem li3 = new ListItem("Delhi");
            List1.Items.Add(li3);

            ListItem li4 = new ListItem("Noida");
            List1.Items.Add(li4);


        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}