using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public double num1, num2,res;
        public string operation;
        public char op;

        public WebForm1()
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        protected void Button9_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="0"&&TextBox1.Text!=null)
            {
                TextBox1.Text = "9";
            }
            else
            TextBox1.Text = TextBox1.Text + "9" ;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "7";
            }
            else
                TextBox1.Text = TextBox1.Text + "7";

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "8";
            }
            else
                TextBox1.Text = TextBox1.Text + "8";


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "4";
            }
            else
                TextBox1.Text = TextBox1.Text + "4";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "5";
            }
            else
                TextBox1.Text = TextBox1.Text + "5";

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "6";
            }
            else
                TextBox1.Text = TextBox1.Text + "6";

        }

        protected void clear_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length>0)
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
            }
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            
        }

        protected void add_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            operation = "+";
            op = '+';
        }

        protected void minus_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text!="")
            {
                num1 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
                operation = "-";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "1";
            }
            else
                TextBox1.Text = TextBox1.Text + "1";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "2";
            }
            else
                TextBox1.Text = TextBox1.Text + "2";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "3";
            }
            else
                TextBox1.Text = TextBox1.Text + "3";

        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            operation = "*";
        }

        protected void point_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = ".";
            }
            else
                TextBox1.Text = TextBox1.Text + ".";

        }

       
        protected void Button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button0.Text;
        }

        protected void divide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(TextBox1.Text);
           
            TextBox1.Text = "";
            operation = "/";
           
        }
        protected void equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            try
            {
                if (op == '+')
                {
                    res = (num1 + num2);


                    TextBox1.Text = TextBox1.Text + res;

                    num1 = res;
                }

                if (operation == "-")
                {
                    res = (num1 - num2);
                    TextBox1.Text = TextBox1.Text + res;

                    num1 = res;
                }

                if (operation == "*")
                {
                    res = (num1 * num2);

                    TextBox1.Text = TextBox1.Text + res;

                    num1 = res;

                }
                if (operation == "/")
                {

                    try
                    {
                        res = (num1 / num2);



                        TextBox1.Text = TextBox1.Text + res;

                        num1 = res;
                    }
                    catch (ArithmeticException)
                    {

                        Response.Write("divide by zero exception occurred");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

       
          
          
               
                
                
                
                
                
                   
            
          
    }



}