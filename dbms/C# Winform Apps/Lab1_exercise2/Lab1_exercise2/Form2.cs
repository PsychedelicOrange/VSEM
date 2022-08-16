﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_exercise2
{
    public partial class Form2 : Form
    {
        string local_message;
        Form1 local_form1;
        public Form2(string message,Form1 form1)
        {
            local_form1 = form1;
            local_message = message;
            InitializeComponent();
            form1.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = local_message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            local_form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            local_form1.Visible = true;
            this.Close();
        }
    }
}
