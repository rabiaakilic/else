﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            if (cbKirmizi.Checked == true)
            {
                lblYaz.Text = "kırmızı yapıldı";

            }
            else
            {
                lblYaz.Text = "kırmızı kaldırıldı";
            }
        }   
    }
}
