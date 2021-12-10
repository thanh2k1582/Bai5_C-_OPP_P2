using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLKS quanLyKhachthue= new QLKS();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY KHACH SAN");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them khach thue.                              **");
                Console.WriteLine("**  2. Tim va xoa khach theo so CMND.                **");
                Console.WriteLine("**  3. Hien thi khach thue.                          **");
                Console.WriteLine("**  4. Tinh tien thue.                               **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        quanLyKhachthue.NhapKs();
                        Console.WriteLine("\nThem khach hang thanh cong!");
                        break;
                    case 2:
                        Console.Write("\nNhap so CMND muon xoa: ");
                        string name2 = Convert.ToString(Console.ReadLine());
                        if (quanLyKhachthue.DeleteBySoCMND(name2))
                        {
                            Console.WriteLine("\nThong tin khach hang da bi xoa!.", name2);
                        }
                        break;

                    case 3:
                        quanLyKhachthue.XuatKS(quanLyKhachthue.getListKhachThue());
                        break;
                    case 4:
                        Console.Write("\nNhap so CMND khach hang: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<Nguoi> searchResult1 = quanLyKhachthue.timKiemKH(name);
                        Console.WriteLine("Chon loai phong thue: ");
                        Console.WriteLine("1.Loai A(500$/day)");
                        Console.WriteLine("2.Loai B(300$/day)");
                        Console.WriteLine("3.Loai C(100$/day)");
                        int n = Int32.Parse(Console.ReadLine());
                        int a; string b;
                        Console.WriteLine("So ngay thue: ");
                        int m = Int32.Parse(Console.ReadLine());
                        quanLyKhachthue.XuatKS(searchResult1);
                        switch (n) {
                            case 1:
                                a = 500;
                                Console.Write("So tien khach phai tra: {0}",m*a);
                                break;
                            case 2:
                                a = 300;
                                Console.Write("So tien khach phai tra: {0}", m * a);
                                break;
                            case 3:
                                a = 100;
                                Console.Write("So tien khach phai tra: {0}", m * a);
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
