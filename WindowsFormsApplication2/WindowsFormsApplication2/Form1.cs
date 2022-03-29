using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form{
        string sign;
        double val1;
        double val2;
        int trackkeypoint=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "1";
            else
                btnMain.Text = btnMain.Text + "1";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "0";
            else
                btnMain.Text = btnMain.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "2";
            else
                btnMain.Text = btnMain.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "3";
            else
                btnMain.Text = btnMain.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "4";
            else
                btnMain.Text = btnMain.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "5";
            else
                btnMain.Text = btnMain.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "6";
            else
                btnMain.Text = btnMain.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "7";
            else
                btnMain.Text = btnMain.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "8";
            else
                btnMain.Text = btnMain.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btnMain.Text == "0")
                btnMain.Text = "9";
            else
                btnMain.Text = btnMain.Text + "9";
        }

        private void btn_bang_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(btnMain.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                btnMain.Text = result.ToString();
                sign = "-";
                val1 = double.Parse(btnMain.Text);
                btnMain.Text = "";
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                btnMain.Text = result.ToString();
                sign = "-";
                val1 = double.Parse(btnMain.Text);
                btnMain.Text = "";
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                btnMain.Text = result.ToString();
                sign = "-";
                val1 = double.Parse(btnMain.Text);
                btnMain.Text = "";
            }
            else
            {
                result = val1 / val2;
                btnMain.Text = result.ToString();
                sign = "-";
                val1 = double.Parse(btnMain.Text);
                btnMain.Text = "";
            }
        }
         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            btnMain.Text = "0";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(btnMain.Text);
            btnMain.Text = "";
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(btnMain.Text);
            btnMain.Text = "";
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(btnMain.Text);
            btnMain.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(btnMain.Text);
            btnMain.Text = "";
        }


    }
}
