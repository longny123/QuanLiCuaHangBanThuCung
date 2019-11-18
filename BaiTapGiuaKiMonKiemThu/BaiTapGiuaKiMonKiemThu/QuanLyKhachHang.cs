using BaiTapGiuaKiMonKiemThu.ClassObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapGiuaKiMonKiemThu
{
    public partial class QuanLyKhachHang : Form
    {
        Error error = new Error();
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            string query = "select * from KhachHang";
            dgvkhachhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        bool Them(string HoTen, string GioiTinh, DateTime NgaySinh, string SDT)
        {
            return KhachHang.Instance.IsThem(HoTen, GioiTinh, NgaySinh, SDT);
        }
        private void BtnThemKH_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            string GioiTinh = txtGioiTinh.Text;
            DateTime NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            string SDT = txtSDT.Text;
            if (!error.checkerror_GioiTinh(GioiTinh))
            {
                MessageBox.Show("Giới tính không hợp lệ", "Error");
            }
            else
            {
                try
                {
                    DateTime.ParseExact(txtNgaySinh.Text, "MM/dd/yyyy", null);
                    if (Them(HoTen, GioiTinh, NgaySinh, SDT))
                    {

                        MessageBox.Show("Thêm thành công", "thông báo");
                        HienThi();
                    }

                    else
                    {
                        MessageBox.Show("Thêm thất bại", "thông báo");
                        HienThi();
                    }
                }
                catch
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                }
            }
        }
        bool Sua(int MaKH, string HoTen, string GioiTinh, DateTime NgaySinh, string SDT)
        {
            return KhachHang.Instance.IsSua(MaKH,HoTen, GioiTinh, NgaySinh, SDT);
        }
        private void BtnSuaKH_Click(object sender, EventArgs e)
        {
            int MaKH = int.Parse(txtMaKH.Text);
            string HoTen = txtHoTen.Text;
            string GioiTinh = txtGioiTinh.Text;
            DateTime NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            string SDT = txtSDT.Text;
            if (!error.checkerror_GioiTinh(GioiTinh))
            {
                MessageBox.Show("Giới tính không hợp lệ", "Error");
            }
            else
            {
                try
                {
                    DateTime.ParseExact(txtNgaySinh.Text, "MM/dd/yyyy", null);
                    if (Sua(MaKH, HoTen, GioiTinh, NgaySinh, SDT))
                    {

                        MessageBox.Show("Sửa thành công", "thông báo");
                        HienThi();
                    }

                    else
                    {
                        MessageBox.Show("Sửa thất bại", "thông báo");
                        HienThi();
                    }
                }
                catch
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Error");
                }
            }
        }
        bool Xoa(int MaKH)
        {
            return KhachHang.Instance.IsXoa(MaKH);
        }
        private void BtnXoaKH_Click(object sender, EventArgs e)
        {
            int MaKH = int.Parse(txtMaKH.Text);

            if (Xoa(MaKH))
            {
                MessageBox.Show("Xóa thành công", "thông báo");
                HienThi();
            }

            else
            {
                MessageBox.Show("Xóa thất bại", "thông báo");
                HienThi();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh tt = new GiaoDienChinh();
            tt.ShowDialog();
            this.Close();
        }
        bool nonNumberEntered = false;
        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void TxtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
    }
}
