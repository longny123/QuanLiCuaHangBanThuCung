using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKiMonKiemThu.ClassObject
{
    public class NhapHangMoi
    {
        private static NhapHangMoi instance;

        internal static NhapHangMoi Instance {
            get { if (instance == null) instance = new NhapHangMoi(); return instance; }
            set => instance = value;
        }
        public NhapHangMoi() { }
        public bool isNhap()
        {
            string cmd = "exec NhapHang";
            int result = DataProvider.Instance.ExecuteNonQuery(cmd);
            return result > 0;
        }
        public bool isHuy()
        {
            string cmd = "delete top(10) from NhapHangMoi";
            int result = DataProvider.Instance.ExecuteNonQuery(cmd);
            return result > 0;
        }
    }
}
