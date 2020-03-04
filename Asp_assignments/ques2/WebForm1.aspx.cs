using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ques2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       static double num1=0,num2=0,res=0;
       static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";

        }

        protected void point_Click(object sender, EventArgs e)
        {
            

                TextBox1.Text = TextBox1.Text + ".";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

                TextBox1.Text = TextBox1.Text + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           

                TextBox1.Text = TextBox1.Text + "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           

                TextBox1.Text = TextBox1.Text + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           

                TextBox1.Text = TextBox1.Text + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           
                TextBox1.Text = TextBox1.Text + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
          

                TextBox1.Text = TextBox1.Text + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
                TextBox1.Text = TextBox1.Text + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            

                TextBox1.Text = TextBox1.Text + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
           

                TextBox1.Text = TextBox1.Text + "9";
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
            }
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
        }

        protected void add_Click(object sender, EventArgs e)
        {
            num1 =num1+ double.Parse(TextBox1.Text);
            TextBox1.Text = " ";
            count = 1;
        }


        protected void minus_Click(object sender, EventArgs e)
        {
            num1 += Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            count = 2;

        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            num1 += Convert.ToDouble(TextBox1.Text);
          
            TextBox1.Text = "";
            count = 3;
        }

        protected void divide_Click(object sender, EventArgs e)
        {
            num1 += Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";

            count = 4;

           
        }



        protected void equal_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                num2 = Convert.ToDouble(TextBox1.Text);

                TextBox1.Text = " ";
                

                switch (count)
                {
                    case 1:
                        

                        res = num1 + num2;

                        TextBox1.Text = res.ToString();
                        num1 = 0;

                        break;
                    case 2:
                        res = num1 - num2;
                        TextBox1.Text = res.ToString();
                        num1 = 0;
                        break;

                    case 3:
                        res = num1 * num2;
                       
                        TextBox1.Text = res.ToString();
                        num1 = 0;

                        break;
                    case 4:
                        try
                        {
                            res = num1 / num2;
                            TextBox1.Text = res.ToString();
                            num1 = 0;
                        }
                        catch (ArithmeticException)
                        {

                            Response.Write("can not divde by zero");
                        }
                        break;
                    default:
                       
                        break;

                }
            }
             catch (Exception)
             {

                Response.Write("exception occurred");
             }
        }
    }
}