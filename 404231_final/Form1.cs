﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404231_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello world~~");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botton1 show");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
