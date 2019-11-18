using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTapGiuaKiMonKiemThu
{
    public class Error
    {
        public bool checkerror(string id, string pass)
        {
            if (id == "")
                return false;
            if (pass == "")
                return false;
            if (id.Length < 5 || id.Length > 15)
                return false;
            if (pass.Length < 5 || pass.Length > 15)
                return false;
            return true;
        }
        public bool login(string id, string pass)
        {
            if (id == "admin" && pass == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkerror_SP(string ten, string soluong, string giaban, string mansx)
        {
            if (ten == "")
                return false;
            if (soluong == "")
                return false;
            if (giaban == "")
                return false;
            if (mansx == "")
                return false;
            return true;
        }
        public bool checkerror_TimKiem(string ten)
        {
            if (ten == "")
                return false;
            return true;
        }
        public bool checkerror_GioiTinh(string gt)
        {
            if (gt == "Nam" || gt == "Nữ" || gt == "Khác")
                return true;
            return false;
        }
    }
}
