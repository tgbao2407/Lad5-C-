using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Lad5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button21_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "(";
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + ")";
        }


        protected void Button25_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = "";
            Answer.Text = "";
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            string DisplayText = DisplayTextBox1.Text;
            int LastIndex = DisplayText.Length;
            DisplayTextBox1.Text = DisplayTextBox1.Text.Remove(LastIndex - 1);

        }

        protected void ButtonNumberEqual_Click(object sender, EventArgs e)
        {

            try
            {
                string Input = DisplayTextBox1.Text;
                DataTable table = new DataTable();
                Object answer;
                answer = table.Compute(Input, null);
                Answer.Text = answer.ToString();
            }

            catch
            {
                Answer.Text = "ERROR :(";
            }

        }

        protected void ButtonNumber1_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text+ "1";
        }

        protected void ButtonNumber2_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text +  "2";
        }

        protected void ButtonNumber3_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "3";
        }

        protected void ButtonNumber4_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "4";
        }

        protected void ButtonNumber5_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "5";
        }

        protected void ButtonNumber6_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "6";
        }

        protected void ButtonNumber7_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "7";
        }

        protected void ButtonNumber8_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "8";
        }

        protected void ButtonNumber9_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "9";
        }

        protected void ButtonNumber0_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "0";
        }

        protected void ButtonNumberdot_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + ".";
        }

        protected void ButtonNumberPlus_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "+";
        }

        protected void ButtonNumberMinus_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "-";

        }

        protected void ButtonNumberMulti_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "*";
        }

        protected void ButtonNumberDevide_Click(object sender, EventArgs e)
        {
            DisplayTextBox1.Text = DisplayTextBox1.Text + "/";
        }  
    }
}