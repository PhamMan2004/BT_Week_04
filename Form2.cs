﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web4
{
    public partial class Form2 : Form
    {
        public Form2(String img)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(img);
            Text = img.Substring(img.LastIndexOf('\\') + 1);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
