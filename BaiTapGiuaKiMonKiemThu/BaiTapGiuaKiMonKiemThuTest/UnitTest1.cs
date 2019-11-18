using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaiTapGiuaKiMonKiemThu;
using BaiTapGiuaKiMonKiemThu.ClassObject;

namespace BaiTapGiuaKiMonKiemThuTest
{
    [TestClass]
    public class UnitTest1  
    {
        private readonly Error log_in = new Error();
        private HangHoa Supply = new HangHoa();
        private KhachHang Cus = new KhachHang();
        private NhapHangMoi Nsx = new NhapHangMoi();

        [TestMethod]
        public void TestAccount_Legal() //Test hợp lệ
        {
            Assert.IsTrue(log_in.checkerror("admin", "admin"), "Có lỗi xuất hiện?");
        }

        [TestMethod]
        public void TestAccount_Illegal() //Test không hợp lệ
        {
            Assert.IsFalse(log_in.checkerror("admin", ""), "Có lỗi xuất hiện?");
        }

        [TestMethod]
        public void TestAccount_WrongAccount() //Test tài khoản sai
        {
            Assert.IsFalse(log_in.login("admins", "admin"), "Có lỗi xuất hiện?");
        }

        [TestMethod]
        public void TestAccount_Success() //Test tài khoản đúng
        {
            Assert.IsTrue(log_in.login("admin", "admin"), "Có lỗi xuất hiện?");
        }

        [TestMethod]
        public void TestTimKiem_Success() //Test tìm kiếm đúng
        {
            Assert.IsTrue(log_in.checkerror_TimKiem("Phạm Văn A"), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestTimKiem_Empty() //Test tìm kiếm trống
        {
            Assert.IsFalse(log_in.checkerror_TimKiem(""), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestSP_Success() //Test sản phẩm đúng
        {
            Assert.IsTrue(log_in.checkerror_SP("Bull", "2", "10000", "NSXVN"), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestThemHangHoa() //Test Thêm Hàng hóa
        {
            Assert.IsTrue(Supply.IsThem("Bull", 2, 10000, "Nước", "NSXVN"), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestSuaHangHoa() //Test Sửa Hàng Hóa
        {
            Assert.IsTrue(Supply.IsSua(1, "Bull", 4, 20000, "Nước tăng lực", "NSXR"), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestXoaHangHoa() //Test Xóa Hàng Hóa
        {
            Assert.IsTrue(Supply.IsXoa(1), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestThemKhachHang() //Test Thêm khách hàng
        {
            Assert.IsTrue(Cus.IsThem("Phạm Văn Khiết", "Nam", DateTime.Parse("11/18/1994"), "0909853215"), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestSuaKhachHang() //Test Sửa khách hàng
        {
            Assert.IsTrue(Cus.IsSua(13, "Phạm Hoàng Hải", "Nam", DateTime.Parse("14/1/1945"), "0809563214"), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestXoaKhachHang() //Test Xóa khách hàng
        {
            Assert.IsTrue(Cus.IsXoa(14), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestNhapNSX() //Test Nhập Nhà Sản Xuất
        {
            Assert.IsTrue(Nsx.isNhap(), "Có lỗi xuất hiện?");
        }
        [TestMethod]
        public void TestHuyNSX() //Test Hủy Nhà Sản Xuất
        {
            Assert.IsTrue(Nsx.isHuy(), "Có lỗi xuất hiện?");
        }
    }
}
