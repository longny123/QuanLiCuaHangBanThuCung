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
    public partial class ThanhToan : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C5FJA28;Initial Catalog=PetStore;Integrated Security=True");
        public ThanhToan()
        {
            InitializeComponent();
        }
        int Tong = 0;
       
        private void BtnTimKH_Click(object sender, EventArgs e)
        {
                string sqlcmd = "select MaKH from KhachHang where HoTen = N'" + cbKH.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txtMaKH.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
       
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petStoreDataSet3.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter3.Fill(this.petStoreDataSet4.HangHoa);
            // TODO: This line of code loads data into the 'petStoreDataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.petStoreDataSet2.KhachHang);
            //Thêm cột vào listview
            lvGioHang.Columns.Add("Tên Sản Phẩm", 100);
            lvGioHang.Columns.Add("Giá Bán", 100);
            lvGioHang.Columns.Add("Số lượng", 100);
            lvGioHang.View = View.Details;
        }
        Error error = new Error();
        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            if (error.checkerror_TimKiem(txtSoLuong.Text))
            {
                string sqlcmd = "select GiaBan from HangHoa where TenHH = N'" + cbSP.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ListViewItem item = new ListViewItem(cbSP.SelectedValue.ToString());
                item.SubItems.Add(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                item.SubItems.Add(txtSoLuong.Text);
                lvGioHang.Items.Add(item);
                lbGiaBan.Text = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString()) * int.Parse(txtSoLuong.Text.ToString()) + "VND";
                Tong += int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString()) * int.Parse(txtSoLuong.Text);
                lbTongTien.Text = Tong + "VND";
                string sqlHH = "select MaHH from HangHoa where TenHH = N'" + cbSP.SelectedValue.ToString() + "'";
                SqlCommand cmdHH = new SqlCommand(sqlHH, conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmdHH);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                txtMaSP.Text = ds1.Tables[0].Rows[0].ItemArray[0].ToString();

            }
            else
               MessageBox.Show("Xin hãy điền đầy đủ dữ liệu!", "Lỗi");
        }
        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime now = DateTime.Now;
            foreach (ListViewItem item in lvGioHang.Items) {
                string sqlTT = @"insert into ChiTietDonHang(MaKH,MaHH,TenHH,SoLuong,TongTien,NgayMua) values('" + txtMaKH.Text + "','" + txtMaSP.Text + "','" + item.Text+"','"+ txtSoLuong.Text+"','"+Tong.ToString()+"','"+now.ToShortDateString()+"')";
                SqlCommand cmd = new SqlCommand(sqlTT, conn);
                cmd.ExecuteNonQuery();
            }
            
            MessageBox.Show("Cảm ơn bạn đã thanh toán", "Cảm ơn", MessageBoxButtons.OK);
            conn.Close();
            this.Hide();
            QuanLySanPham gd = new QuanLySanPham();
            gd.ShowDialog();
            this.Close();
        }
        bool nonNumberEntered = false;
        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh tt = new GiaoDienChinh();
            tt.ShowDialog();
            this.Close();
        }
    }

}
