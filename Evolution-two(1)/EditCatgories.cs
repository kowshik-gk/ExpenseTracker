﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution_two_1_
{
    public partial class EditCatgories : Form
    {
        public EventHandler<string> Add;
        public EventHandler<string> Remove;
        public EditCatgories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add?.Invoke(sender, textBox2.Text);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Remove?.Invoke(sender, textBox2.Text);
            this.Hide();
        }
    }
}
