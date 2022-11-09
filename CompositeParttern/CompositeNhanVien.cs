using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttern
{
    public class CompositeNhanVien : INhanVien
    {
        public string HoTen { get; set; }
        public string PBan { get; set; }
        public string GhiChu { get; set; }

        private List<INhanVien> Ds = new List<INhanVien>();
        public void HThiChiTiet()
        {
            Console.WriteLine($" {HoTen} working in room {PBan}, Ghi chu: {GhiChu}" );

            foreach(INhanVien e in Ds)
            {
                e.HThiChiTiet();
            }
        }
        public void AddNhanVien(INhanVien nhanVien)
        {
            Ds.Add(nhanVien);
        }
        public void RemoveNhanVien(INhanVien nhanVien)
        {
            Ds.Remove(nhanVien);
        }
    }
}
