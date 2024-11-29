using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_TUAN_4
{
    internal class NhanVien
    {
        // Thuộc tính
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCB { get; set; }

        // Constructor
        public NhanVien(string msnv, string tenNv, decimal luongCb)
        {
            MSNV = msnv;
            TenNV = tenNv;
            LuongCB = luongCb;
        }

        // Phương thức để trả về thông tin nhân viên
        public override string ToString()
        {
            return $"{MSNV} - {TenNV} - {LuongCB:C}";
        }
    }
}
