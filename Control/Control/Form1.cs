using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_number_TextChanged(object sender, EventArgs e)
        {
           
             if (input_number.Text != "")
                {
                    try
                    {
                        int a = Int32.Parse(input_number.Text.Trim());

                    }
                    catch
                    {
                        MessageBox.Show("Bạn không được nhập chữ");
                        input_number.Text = "";
                        input_number.Focus();
                    }
                }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (input_number.Text == "")
            {
                MessageBox.Show("Moi ban nhap so");
            }
            else
            {
                if (listbox_left.Items.Contains(input_number.Text))
                {
                    MessageBox.Show("4.There seems to be a duplicate item in your listbox");
                }
                else
                {
                    listbox_left.Items.Add(input_number.Text);
                    input_number.Text = "";
                }
            }
        }

        private void move_left_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(listbox_left.SelectedItem);
            string b = Convert.ToString(listbox_right.SelectedItem);
            if (listbox_left.Items.Count == 0)
            {
                MessageBox.Show("Box 1 is empty");
            }
            else
            {
                if (b.Contains(a))
                {
                    MessageBox.Show("333.There seems to be a duplicate item in your listbox");
                }
                else{
                    listbox_right.Items.Add(listbox_left.SelectedItem);
                    while (listbox_left.SelectedIndices.Count != 0)
                    {
                        listbox_left.Items.RemoveAt(listbox_left.SelectedIndices[0]);
                    }
                }
            }
        }


        private void move_right_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(listbox_left.SelectedItem);
            string b = Convert.ToString(listbox_right.SelectedItem);
   
            if (listbox_right.Items.Count == 0)
            {
                MessageBox.Show("Box 2 is empty");
            }
            else
            {
                if (b.Contains(a))
                {
                    MessageBox.Show("33333.There seems to be a duplicate item in your listbox");
                }
                else
                {
                    listbox_left.Items.Add(listbox_right.SelectedItem);
                    while (listbox_right.SelectedIndices.Count != 0)
                    {
                        listbox_right.Items.RemoveAt(listbox_right.SelectedIndices[0]);
                    }
                }
            }
         }

        private void del_Click(object sender, EventArgs e)
        {
            listbox_left.Items.Remove(listbox_left.SelectedItem);
            listbox_right.Items.Remove(listbox_right.SelectedItem);  
        }

        private void listbox_left_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_left.Items.Contains(listbox_left))
            {
                MessageBox.Show("1.There seems to be a duplicate item in your listbox");
            }
        }

        private void listbox_right_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_right.Items.Contains(listbox_right.Items))
            {
                MessageBox.Show("2.There seems to be a duplicate item in your listbox");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
     
      
    }
}
