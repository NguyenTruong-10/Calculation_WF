using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBasic
{
    public partial class Form1 : Form
    {
        //int first_charge = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Program.check_data = Program.Read_file();
            if (Program.Read_file() == null)
            {
               
                if (Program.first_money > 0)
                {
                    Program.money_credits = Program.first_money;
                    Program.Save_file(Program.money_credits);
                    money.Text = "";
                   this.Hide();
                    New_Form new_Form = new New_Form();
                    new_Form.Show();
                }
                else
                {
                    MessageBox.Show("Bạn chưa có tiền.");
                }
            }
            else if(Program.Read_file() != null)
            {
                if (Program.first_money > 0)
                {
                    Program.money_credits = Program.first_money + Int32.Parse(Program.Read_file());
                    Program.Save_file(Program.money_credits);
                money.Text = "";
                    this.Hide();
                    New_Form new_Form = new New_Form();
                    new_Form.Show();
                }
                else if (Int32.Parse(Program.Read_file()) >= 0)
                {
                    Program.money_credits = Int32.Parse(Program.Read_file());
                money.Text = "";
                    this.Hide();
                    New_Form new_Form = new New_Form();
                    new_Form.Show();
                }
                else
                {
                money.Text = "Bạn đang nợ " + (Int32.Parse(Program.Read_file()) * -1).ToString() + "$";
                MessageBox.Show("Bạn đang nợ, bạn phải trả nợ trước.");
                }
             }
            
            else
            {
                MessageBox.Show("Error");
            }
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program.first_money = Program.money_credits;
            //MessageBox.Show(Program.money_credits.ToString());
        }

        private void btn_recharge_Click(object sender, EventArgs e)
        {
            Program.check = false;
            Recharge recharge = new Recharge();
            recharge.Show();
            this.Refresh();
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
