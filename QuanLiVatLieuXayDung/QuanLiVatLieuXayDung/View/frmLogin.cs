﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiVatLieuXayDung.Controller;

namespace QuanLiVatLieuXayDung.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UserController userController = new UserController();
        public static string rule { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin.", "Lỗi");
            }else
            if (userController.GetUserByUserName(txtUsername.Text, txtPassword.Text) == true)
            {
                rule = userController.rule;
                if (rule == "admin")
                {
                    Form1 form1 = new Form1();
                    form1.Show(); 
                }else
                if (rule =="Nhân viên bán hàng")
                {
                    frmBanhang frmbanhang = new frmBanhang();
                    frmbanhang.Show();
                }else
                    if(rule=="Nhân viên kế toán")
                {
                    frmKetoan frmKetoan = new frmKetoan();
                    frmKetoan.Show();
                }else if (rule =="Quản lí kho")
                {
                    frmQuanlykho frmQuanlykho = new frmQuanlykho();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Đăng nhập thất bại!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
