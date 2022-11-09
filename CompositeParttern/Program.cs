using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien hc1 = new NhanVien { HoTen = "A", PBan = "HanhChinh", GhiChu = "Nhan Vien" };
            NhanVien hc2 = new NhanVien { HoTen = "E", PBan = "HanhChinh", GhiChu = "Nhan Vien" }; 
            NhanVien hc3 = new NhanVien { HoTen = "F", PBan = "HanhChinh", GhiChu = "Nhan Vien" };
            hc1.HThiChiTiet();

            CompositeNhanVien TPHC = new CompositeNhanVien { HoTen="K",PBan="Hanh Chinh",GhiChu="Truong Phong"};
            TPHC.AddNhanVien(hc1);
            TPHC.AddNhanVien(hc2);
            TPHC.AddNhanVien(hc3);

            NhanVien sx1 = new NhanVien { HoTen = "B", PBan = "SanXuat", GhiChu = "Nhan Vien" };
            NhanVien sx2 = new NhanVien { HoTen = "C", PBan = "SanXuat", GhiChu = "Nhan Vien" };
            NhanVien sx3 = new NhanVien { HoTen = "D", PBan = "SanXuat", GhiChu = "Nhan Vien" };

            CompositeNhanVien TPSX = new CompositeNhanVien { HoTen = "SX", PBan = "SanXuat", GhiChu = "Truong Phong" };
            TPSX.AddNhanVien(sx1);
            TPSX.AddNhanVien(sx2);
            TPSX.AddNhanVien(sx3);

            CompositeNhanVien GD = new CompositeNhanVien { HoTen = "GD", PBan = "TongGiamDoc", GhiChu = "GiamDoc" };
            GD.AddNhanVien(TPHC);
            GD.AddNhanVien(TPSX);

            GD.HThiChiTiet();

            //Co 1 nguoi nghi
            Console.WriteLine("Thong tin ca nhan cua HC3");
            hc3.HThiChiTiet();
            Console.WriteLine("HC3 submit don nghi");
            TPHC.RemoveNhanVien(hc3);
            GD.HThiChiTiet();

        }
    }
}
