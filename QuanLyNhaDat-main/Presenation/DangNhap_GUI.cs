using QuanLyNhaDat.BLL;
using QuanLyNhaDat.BLL.Interface;
using QuanLyNhaDat.DAL;
using System;
using System.Collections;
using System.Text;

namespace QuanLyNhaDat.GUI
{
    class DangNhap_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("                                 ---------------------------------------------------");
            Console.WriteLine("                                 |                  1.Đăng nhập                    |");
            Console.WriteLine("                                 ---------------------------------------------------");
            Console.WriteLine("                                 |                  2.Đăng kí                      |");
            Console.WriteLine("                                 ---------------------------------------------------");
            Console.WriteLine("                                 |                  0.Thoát                        |");
            Console.WriteLine("                                 ---------------------------------------------------");
        }
      
        static SanPham_BLL SanPham_BLL = new SanPham_BLL();
     
        public static void Chon(ArrayList arrayList)
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        bool kt = true;
                        if (kt == DangNhap_BLL.DangNhap(arrayList))
                        {
                            Console.WriteLine("                                 Đăng nhập thành công");
                            Console.ReadKey();
                            Console.Clear();
                            SanPham_GUI.Run(SanPham_BLL);
                            
                        }
                        else
                        {
                            Console.WriteLine("                                 Đăng nhập thất bại");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        DangNhap_BLL.TaoTK(arrayList);
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
