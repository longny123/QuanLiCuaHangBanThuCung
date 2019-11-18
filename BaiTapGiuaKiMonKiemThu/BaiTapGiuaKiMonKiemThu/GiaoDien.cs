using MySql.Data.MySqlClient;
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
    public partial class GiaoDien : Form    
    {
        DataConnect db = new DataConnect();
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db.OpenConnect();
            dt = db.ReadData();
            dgvHienCo.DataSource = dt;
            db.CloseConnect();
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

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DialogResult dlt =  MessageBox.Show("Bạn có chắc là muốn off ca làm", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlt == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
