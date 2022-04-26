namespace Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_left = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.listbox_right = new System.Windows.Forms.ListBox();
            this.move_left = new System.Windows.Forms.Button();
            this.move_right = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_number = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_left
            // 
            this.listbox_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_left.FormattingEnabled = true;
            this.listbox_left.ItemHeight = 20;
            this.listbox_left.Location = new System.Drawing.Point(19, 119);
            this.listbox_left.Name = "listbox_left";
            this.listbox_left.Size = new System.Drawing.Size(134, 164);
            this.listbox_left.TabIndex = 2;
            this.listbox_left.SelectedIndexChanged += new System.EventHandler(this.listbox_left_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(193, 58);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(53, 40);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(280, 58);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(55, 40);
            this.del.TabIndex = 4;
            this.del.Text = "delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // listbox_right
            // 
            this.listbox_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_right.FormattingEnabled = true;
            this.listbox_right.ItemHeight = 20;
            this.listbox_right.Location = new System.Drawing.Point(243, 119);
            this.listbox_right.Name = "listbox_right";
            this.listbox_right.Size = new System.Drawing.Size(134, 164);
            this.listbox_right.TabIndex = 5;
            this.listbox_right.SelectedIndexChanged += new System.EventHandler(this.listbox_right_SelectedIndexChanged);
            // 
            // move_left
            // 
            this.move_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move_left.Location = new System.Drawing.Point(2, 29);
            this.move_left.Name = "move_left";
            this.move_left.Size = new System.Drawing.Size(48, 38);
            this.move_left.TabIndex = 7;
            this.move_left.Text = ">";
            this.move_left.UseVisualStyleBackColor = true;
            this.move_left.Click += new System.EventHandler(this.move_left_Click);
            // 
            // move_right
            // 
            this.move_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move_right.Location = new System.Drawing.Point(2, 92);
            this.move_right.Name = "move_right";
            this.move_right.Size = new System.Drawing.Size(48, 35);
            this.move_right.TabIndex = 8;
            this.move_right.Text = "<";
            this.move_right.UseVisualStyleBackColor = true;
            this.move_right.Click += new System.EventHandler(this.move_right_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.move_right);
            this.panel1.Controls.Add(this.move_left);
            this.panel1.Location = new System.Drawing.Point(171, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 164);
            this.panel1.TabIndex = 9;
            // 
            // input_number
            // 
            this.input_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_number.Location = new System.Drawing.Point(19, 64);
            this.input_number.Multiline = true;
            this.input_number.Name = "input_number";
            this.input_number.Size = new System.Drawing.Size(134, 33);
            this.input_number.TabIndex = 10;
            this.input_number.UseSystemPasswordChar = true;
            this.input_number.TextChanged += new System.EventHandler(this.input_number_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 313);
            this.Controls.Add(this.input_number);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listbox_right);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listbox_left);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_left;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.ListBox listbox_right;
        private System.Windows.Forms.Button move_left;
        private System.Windows.Forms.Button move_right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox input_number;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

