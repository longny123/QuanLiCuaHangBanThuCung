using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKiMonKiemThu.ClassObject
{
     public class HangHoa
    {
        private static HangHoa instance;

        internal static HangHoa Instance {
            get { if (instance == null) instance = new HangHoa(); return instance; }
            set => instance = value;
        }
        public HangHoa() { }
        public bool IsThem(string TenHH, int SoLuong, float GiaBan, string GhiChu, string MaNSX)
        {
            string sqlInsert = @"exec ThemSanPhamMoi "+ TenHH +" ," + SoLuong + " ,"+ GiaBan +" ,"+ GhiChu + " ," + MaNSX ;
            int result = DataProvider.Instance.ExecuteNonQuery(sqlInsert);
            return result > 0;
        }
        public bool IsSua(int MaHH,string TenHH, int SoLuong, float GiaBan, string GhiChu, string MaNSX)
        {
            string sqlEdit = @"update HangHoa set TenHH = '"+ TenHH +"' , SoLuong = '"+SoLuong+"' , GiaBan = "+GiaBan+ " , GhiChu = '"+GhiChu+"' , MaNSX = '"+MaNSX+"' where MaHH = '"+MaHH+"' ";
            int result = DataProvider.Instance.ExecuteNonQuery(sqlEdit);
            return result > 0;
        }
        public bool IsXoa(int MaHH)
        {
            string sqlDelete = @"delete from HangHoa where MaHH = "+MaHH+" ";
            int result = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
            return result > 0;
        }
        public bool IsTim(int MaHH)
        {
            string sqlDelete = @"select *  from HangHoa where MaHH = " + MaHH + " ";
            DataTable result = DataProvider.Instance.ExecuteQuery(sqlDelete);
            return result.Rows.Count > 0;
        }
    }
}
