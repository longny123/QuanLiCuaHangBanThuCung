using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKiMonKiemThu.ClassObject
{
    class ChiTietDonHang
    {
        private string MaDH;
        private int MaKH;
        private string MaHH;
        private int TongSoLuong;
        private float TongTien;
        private DateTime NgayMua;

        public ChiTietDonHang()
        {
            this.MaDH1 = MaDH1;
            this.MaKH1 = MaKH1;
            this.MaHH1 = MaHH1;
            this.TongSoLuong1 = TongSoLuong1;
            this.TongTien1 = TongTien1;
            this.NgayMua1 = NgayMua1;
        }

        public string MaDH1 { get => MaDH; set => MaDH = value; }
        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaHH1 { get => MaHH; set => MaHH = value; }
        public int TongSoLuong1 { get => TongSoLuong; set => TongSoLuong = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
        public DateTime NgayMua1 { get => NgayMua; set => NgayMua = value; }
    }
}
