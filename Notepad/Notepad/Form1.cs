using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sw = new SaveFileDialog();
            sw.DefaultExt = ".txt";
            sw.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = sw.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(sw.FileName, textbox.Text);
            }
    
            sw.Title = "Save";
            if (sw.ShowDialog(this) == DialogResult.OK)
            {

               // System.IO.File.WriteAllText(filename, textbox.Text);
            }

            else
            {
                return;

            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult dr;
            if (textbox.Text != "")
            {
                dr = MessageBox.Show("Do you want to save the file", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr.Equals(DialogResult.Yes))
                {
                    string filename = sfd.FileName;
                    String filter = "Text Files|*.txt|All Files|*.*";
                    sfd.Filter = filter;
                    sfd.Title = "Save";
                    if (sfd.ShowDialog(this) == DialogResult.OK)
                    {

                        System.IO.File.WriteAllText(filename, textbox.Text);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    textbox.Clear();
                }
            }
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textbox.Text = File.ReadAllText(open.FileName);
            }
        }


        private void cmdSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sw = new SaveFileDialog();
            string filename = sw.FileName;
            String filter = "Text Files|*.txt|All Files|*.*";
            sw.Filter = filter;
            sw.Title = "Save";
            if (sw.ShowDialog(this) == DialogResult.OK)
            {
                System.IO.File.WriteAllText(filename, textbox.Text);
            }

            else
            {
                return;

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult dr;
            if (textbox.Text != "")
            {
                dr = MessageBox.Show("Do you want to save the file", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr.Equals(DialogResult.Yes))
                {
                    string filename = sfd.FileName;
                    String filter = "Text Files|*.txt|All Files|*.*";
                    sfd.Filter = filter;
                    sfd.Title = "Save";
                    if (sfd.ShowDialog(this) == DialogResult.OK)
                    {

                        System.IO.File.WriteAllText(filename, textbox.Text);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
