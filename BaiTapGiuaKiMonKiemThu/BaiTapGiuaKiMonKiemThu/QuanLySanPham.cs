using BaiTapGiuaKiMonKiemThu.ClassObject;
using MySql.Data.MySqlClient;
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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            string query = "select * from HangHoa";
            dgvHienCo.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {
            HienThi();
            //lvHienCo.View = View.Details;
            //lvHienCo.Columns.Add("Mã sẩn phẩm", 100);
            //lvHienCo.Columns.Add("Tên sản phẩm", 200);
            //lvHienCo.Columns.Add("Giá bán", 100);
            //lvHienCo.Columns.Add("Số lượng", 100);
            //lvHienCo.Columns.Add("Ghi chú", 250);
            //ListViewItem item1 = new ListViewItem("001");
            //item1.SubItems.Add("Chó Chihuahua");
            //item1.SubItems.Add("10.000.000VND");
            //item1.SubItems.Add("10");
            //item1.SubItems.Add("Được 2 tháng tuổi.Đã tiêm chủng đầy đủ");
            //ListViewItem item2 = new ListViewItem("002");
            //item2.SubItems.Add("Khay Đựng thức ăn");
            //item2.SubItems.Add("100.000VND");
            //item2.SubItems.Add("20");
            //item2.SubItems.Add("Size S:10 , Size M: 10");
            //ListViewItem item3 = new ListViewItem("003");
            //item3.SubItems.Add("Thức ăn cho chó");
            //item3.SubItems.Add("150.000VND");
            //item3.SubItems.Add("100");
            //item3.SubItems.Add("Túi lớn");
            //ListViewItem item4 = new ListViewItem("004");
            //item4.SubItems.Add("Chó Chihuahua");
            //item4.SubItems.Add("10.000.000VND");
            //item4.SubItems.Add("10");
            //item4.SubItems.Add("Được 2 tháng tuổi.Đã tiêm chủng đầy đủ");
            //ListViewItem item5 = new ListViewItem("005");
            //item5.SubItems.Add("Chó Chihuahua");
            //item5.SubItems.Add("10.000.000VND");
            //item5.SubItems.Add("10");
            //item5.SubItems.Add("Được 2 tháng tuổi.Đã tiêm chủng đầy đủ");
            //lvHienCo.Items.Add(item1);
            //lvHienCo.Items.Add(item2);
            //lvHienCo.Items.Add(item3);
            //lvHienCo.Items.Add(item4);
            //lvHienCo.Items.Add(item5);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gdc = new GiaoDienChinh();
            gdc.ShowDialog();
            this.Close();
        }
        Error error = new Error();
        bool Them(string TenHH, int SoLuong, int GiaBan, string GhiChu, string MaNSX)
        {
            return HangHoa.Instance.IsThem(TenHH, SoLuong, GiaBan, GhiChu, MaNSX);
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {

            if (error.checkerror_SP(txtTenSP.Text, txtSoLuong.Text, txtGiaBan.Text, txtMaNSX.Text))
            {
                string TenHH = txtTenSP.Text;
                int SoLuong = int.Parse(txtSoLuong.Text);
                int GiaBan = int.Parse(txtGiaBan.Text);
                string GhiChu = txtGhiChu.Text;
                string MaNSX = txtMaNSX.Text;
                if (Them(TenHH, SoLuong, GiaBan, GhiChu, MaNSX))
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
            else
                MessageBox.Show("Xin hãy điền đầy đủ dữ liệu!", "Lỗi");
        }

        bool Sua(int MaHH, string TenHH, int SoLuong, int GiaBan, string GhiChu, string MaNSX)
        {
            return HangHoa.Instance.IsSua(MaHH, TenHH, SoLuong, GiaBan, GhiChu, MaNSX);
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (error.checkerror_SP(txtTenSP.Text, txtSoLuong.Text, txtGiaBan.Text, txtMaNSX.Text))
            {
                int MaHH = int.Parse(txtMaSP.Text);
                string TenHH = txtTenSP.Text;
                int SoLuong = int.Parse(txtSoLuong.Text);
                int GiaBan = int.Parse(txtGiaBan.Text);
                string GhiChu = txtGhiChu.Text;
                string MaNSX = txtMaNSX.Text;
                if (Sua(MaHH, TenHH, SoLuong, GiaBan, GhiChu, MaNSX))
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
            else
                MessageBox.Show("Xin hãy điền đầy đủ dữ liệu!", "Lỗi");
        }

        bool Xoa(int MaHH)
        {
            return HangHoa.Instance.IsXoa(MaHH);
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (error.checkerror_SP(txtTenSP.Text, txtSoLuong.Text, txtGiaBan.Text, txtMaNSX.Text))
            {
                int MaHH = int.Parse(txtMaSP.Text);
                if (Xoa(MaHH))
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
            else
                MessageBox.Show("Xin hãy điền đầy đủ dữ liệu!", "Lỗi");
        }
        bool Tim(int MaHH)
        {
            return HangHoa.Instance.IsTim(MaHH);
        }
        private void BtnTim_Click(object sender, EventArgs e)
        {
            if (error.checkerror_TimKiem(txtTimKiem.Text))
            {
                int MaHH = int.Parse(txtTimKiem.Text);
                if (Tim(MaHH))
                {
                    MessageBox.Show("Tìm thành công", "thông báo");
                    string query = @"select *  from HangHoa where MaHH = " + MaHH + " ";
                    dgvTimKiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    
                }
                else
                {
                    MessageBox.Show("Tìm thất bại", "thông báo");
                    HienThi();
                }
            }
            else
                MessageBox.Show("Xin hãy điền đầy đủ dữ liệu!", "Lỗi");
        }


        private void BtnNhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nh = new NhapHang();
            nh.ShowDialog();
            this.Close();
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
            this.Close();
        }
        bool nonNumberEntered = false;

        private void TxtSoLuong_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtGiaBan_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void TxtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }
    }
}

