using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaRo
{
    public partial class Form1 : Form
    {
        string LuotDi = "X";
        public Form1()
        {
            InitializeComponent();
            KhoiTaoBanCo();
        }

        private void KhoiTaoBanCo()
        {
            /*Button b = new Button();
            b.Text = "X";
            b.Width = 20;
            Button b1 = new Button();
            b1.Text = "O";
            b1.Width = 20;
            b1.Location = new Point(b1.Location.X + 20, b1.Location.Y);
            this.splitContainer1.Panel2.Controls.Add(b);
            this.splitContainer1.Panel2.Controls.Add(b1);*/
            for(int i = 0; i<20; i++)
            {
                for(int j = 0; j<20; j++)
                {
                    Button b = new Button();
                    b.Name = i.ToString() + "_"+ j.ToString();
                    b.Location = new Point(j * 20, i * 20);
                    b.Size = new Size(20, 20);
                    this.splitContainer1.Panel2.Controls.Add(b);
                    b.Click += b_Click;
                }
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name);
            Button b = (Button)sender;
            
            if (b.Text != "")
            {
                MessageBox.Show("À à ăn gian!");
                return;
            }
            b.Text = LuotDi;
            if (LuotDi == "X")
                LuotDi = "O";
            else
                LuotDi = "X";
        }
    }
}
