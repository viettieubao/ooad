﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiVatLieuXayDung.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ucQlsanpham ucQlsanpham;
        private void Form1_Load(object sender, EventArgs e)
        {
            ucQlsanpham = new ucQlsanpham();
            panel1.Controls.Add(ucQlsanpham);
            ucQlsanpham.Dock = DockStyle.Fill;
            ucQlsanpham.BringToFront();
        }
    }
}
