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
    public partial class NhapHang : Form
    {
        public void HienThi()
        {
            string query = "select * from NhapHangMoi";  
            dgvHienThi.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public NhapHang()
        {
            InitializeComponent();
            HienThi();
        }
        bool Nhap()
        {
            return NhapHangMoi.Instance.isNhap();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dlt = MessageBox.Show("Bạn có chắc là muốn nhập hàng", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlt == DialogResult.OK)
            {
                if (Nhap())
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
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult dlt = MessageBox.Show("Bạn có chắc là muốn thoát", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlt == DialogResult.OK)
            {
                this.Hide();
                GiaoDienChinh gdc = new GiaoDienChinh();
                gdc.ShowDialog();
                this.Close();
            }
        }
        bool Huy()
        {
            return NhapHangMoi.Instance.isHuy();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dlt = MessageBox.Show("Bạn có chắc là muốn hủy đơn", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlt == DialogResult.OK)
            {
                if (Huy())
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
        }
    }
}
