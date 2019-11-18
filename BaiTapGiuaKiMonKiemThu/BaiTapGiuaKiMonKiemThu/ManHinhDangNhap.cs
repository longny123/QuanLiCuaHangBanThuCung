using BaiTapGiuaKiMonKiemThu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapGiuaKiMonKiemThu
{
    public partial class ManHinhDangNhap : Form
    {
        public ManHinhDangNhap()
        {
            InitializeComponent();
        }

        public void exit()
        {
            this.Close();
        }


        //Exit button
        public void button2_Click(object sender, EventArgs e)
        {
            exit();
        }


        //Log in button
        public void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPass.Text;
            Error error = new Error();
            if (error.checkerror(id, pass) == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Error");
            }
            else
            {
                if (error.login(id, pass))
                {
                    this.Hide();
                    GiaoDienChinh form2 = new GiaoDienChinh();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Error");
                }
            }
        }
    }
}
