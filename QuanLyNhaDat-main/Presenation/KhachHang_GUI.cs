using QuanLyNhaDat.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat.GUI
{
    class KhachHang_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("                                  ___________________________________________________");
            Console.WriteLine("                                 |                  QUẢN LÝ KHÁCH HÀNG              |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. Nhập khách hàng                                |");
            Console.WriteLine("                                 |2. Hiện thị danh sách khách hàng                  |");
            Console.WriteLine("                                 |0.Thoát                                           |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        public static void Run(SanPham_BLL sanPham_BLL)
        {
            int chon;


            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        Console.Clear();
                        sanPham_BLL.nhapKhachHang();
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        sanPham_BLL.hienKhachHang();
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
