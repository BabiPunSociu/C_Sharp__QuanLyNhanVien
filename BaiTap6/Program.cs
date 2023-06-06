using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();

            nv.nhap();

            // Hiển thị
            Console.WriteLine("{0,20}" + "|" + "{1,8}" + "|" + "{2,10}" + "|" + "{3,12}" + "|"
                + "{4,5}" + "|" + "{5,8}" + "|" + "{6,10}", "Họ tên", "Năm sinh", "Địa chỉ",
                "Lương cơ bản", "Hệ số", "Phụ cấp", "Tổng tiền");
            nv.xuat();
        }
    }
}