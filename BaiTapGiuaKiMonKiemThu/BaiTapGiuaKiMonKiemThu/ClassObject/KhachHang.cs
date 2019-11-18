using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKiMonKiemThu.ClassObject
{
    public class KhachHang
    {
        private static KhachHang instance;

        internal static KhachHang Instance {
            get { if (instance == null) instance = new KhachHang(); return instance; }
            set => instance = value;
        }
        public KhachHang() { }
        public bool IsThem(string HoTen, string GioiTinh, DateTime NgaySinh, string SDT)
        {
            string sqlInsert = @"exec ThemKhachHangMoi N'" + HoTen + "' ,N'" + GioiTinh + "' ,'" + NgaySinh + "' ,'" + SDT +"' ";
            int result = DataProvider.Instance.ExecuteNonQuery(sqlInsert);
            return result > 0;
        }
        public bool IsSua(int MaKH, string HoTen, string GioiTinh, DateTime NgaySinh, string SDT)
        {
            string sqlEdit = @"update KhachHang set HoTen = N'" + HoTen + "' , GioiTinh = N'" + GioiTinh + "' , NgaySinh = '" + NgaySinh + "' , SDT = '" + SDT + "' where MaKH = '" + MaKH + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(sqlEdit);
            return result > 0;
        }
        public bool IsXoa(int MaKH)
        {
            string sqlDelete = @"delete from KhachHang where MaKH = '" + MaKH + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
            return result > 0;
        }
    }
}
