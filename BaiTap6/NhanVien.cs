using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class NhanVien
    {
        string hoTen, diaChi;
        int namSinh;
        double luongCoBan, heSo, phuCap, tongTien;
        public NhanVien() { }
        
        public void nhap()
        {
            try
            {   // Nhập họ tên
                Console.Write("Nhap ho ten nhan vien: ");
                hoTen = Console.ReadLine();

                // Nhập năm sinh
                do
                {
                    Console.Write("\nNhap nam sinh: ");
                    namSinh = int.Parse(Console.ReadLine());
                }while (namSinh <= 0);

                // Nhập địa chỉ
                Console.Write("\nNhap dia chi: ");
                diaChi = Console.ReadLine();

                // Nhập lương cơ bản
                do
                {
                    Console.Write("\nNhap luong co ban: ");
                    luongCoBan = double.Parse(Console.ReadLine());
                }while(luongCoBan <= 0);

                // Nhập hệ số
                do
                {
                    Console.Write("\nNhap he so:");
                    heSo = double.Parse(Console.ReadLine());
                }while(heSo < 1);

                // Nhập phụ cấp
                do
                {
                    Console.Write("\nNhap phu cap:");
                    phuCap = double.Parse(Console.ReadLine());
                }while(phuCap <= 0);

                // Tính tổng tiền
                tongTien = tinhLuong();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public double tinhLuong()
        {
            return (luongCoBan*heSo + phuCap);
        }

        public void xuat()
        {
            Console.WriteLine("{0,20}" + "|" + "{1,8}" + "|" + "{2,10}" + "|" + "{3,12}" + "|"
                + "{4,5}" + "|" + "{5,8}" + "|" + "{6,10}",hoTen,namSinh,diaChi,luongCoBan,heSo,phuCap,tongTien);
        }
    }
}
