﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstProjectForGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while(true)
            { MessageBox.Show("Errors", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //Добавлен комментарий
        }
    }
}
