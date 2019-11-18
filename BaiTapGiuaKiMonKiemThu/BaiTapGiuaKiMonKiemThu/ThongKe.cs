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
    public partial class ThongKe : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C5FJA28;Initial Catalog=PetStore;Integrated Security=True");
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            String sqlTKT = "select sum(TongTien) as doanhthutheothang from ChiTietDonHang where day(NgayMua) between '1' and '31'";
            SqlCommand cmd1 = new SqlCommand(sqlTKT, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            lbThang.Text = ds1.Tables[0].Rows[0].ItemArray[0].ToString() + "VND";
            String sqlTKN = "select sum(TongTien) as doanhthutheoNgay from ChiTietDonHang where day(NgayMua) = day(GETDATE())";
            SqlCommand cmd = new SqlCommand(sqlTKN, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lbNgay.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString() + "VND";
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gdc = new GiaoDienChinh();
            gdc.ShowDialog();
            this.Close();
        }
    }
}
