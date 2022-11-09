using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttern
{
    //leaf
    public class NhanVien : INhanVien
    {
        public string HoTen { get ; set ; }
        public string PBan { get ; set ; }
        public string GhiChu { get ; set; }

        public void HThiChiTiet()
        {
            Console.WriteLine("\t {0} working in room {1}. Ghi chu: {2}",HoTen,PBan,GhiChu);
        }
    }
}
