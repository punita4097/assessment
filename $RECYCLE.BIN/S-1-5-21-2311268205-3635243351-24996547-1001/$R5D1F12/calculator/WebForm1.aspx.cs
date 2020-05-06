using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        double FirstNumber;
        string Operation;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

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

        protected void Button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";

        }

        protected void dot_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";

        }

        protected void plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
           // TextBox1.Text = "0";
            Operation = "+";

        }

        protected void minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            //TextBox1.Text = "0";
            Operation = "-";

        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            //TextBox1.Text = "0";
            Operation = "*";

        }

        protected void divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            //TextBox1.Text = "0";
            Operation = "/";

        }

        protected void clear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }

        protected void reverse_Click(object sender, EventArgs e)
        {
            
        }

        protected void equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(TextBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                TextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                TextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                TextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    TextBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    TextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}