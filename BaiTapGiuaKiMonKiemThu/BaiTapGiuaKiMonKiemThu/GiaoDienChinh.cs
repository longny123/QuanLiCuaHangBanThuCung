using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapGiuaKiMonKiemThu
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlt = MessageBox.Show("Bạn có chắc là muốn off ca làm", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlt == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnQLNH_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang nh = new NhapHang();
            nh.ShowDialog();
            this.Close();
        }

        private void BtnQLSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySanPham sp = new QuanLySanPham();
            sp.ShowDialog();
            this.Close();
        }

        private void BtnTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
            this.Close();
        }

        private void BtnTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tt = new ThongKe();
            tt.ShowDialog();
            this.Close();
        }

        private void BtnQLKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang tt = new QuanLyKhachHang();
            tt.ShowDialog();
            this.Close();
        }
    }
}
