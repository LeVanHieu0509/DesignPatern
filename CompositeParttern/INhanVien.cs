using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttern
{
    public interface INhanVien
    {
        string HoTen { get; set; }
        string PBan { get; set; }
        string GhiChu { get; set; }
        void HThiChiTiet();

    }
}
