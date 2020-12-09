using QuanLyNhaDat.BLL.Interface;
using QuanLyNhaDat.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat.GUI
{
    class SanPham_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |             CHƯƠNG TRÌNH QUẢN LÍ NHÀ ĐẤT         |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. Nhập thêm nhà                                  |");
            Console.WriteLine("                                 |2. Hiện thị danh sách                             |");
            Console.WriteLine("                                 |3. Sửa thông tin                                  |");
            Console.WriteLine("                                 |4. Xóa nhà                                        |");
            Console.WriteLine("                                 |5. Tìm kiếm                                       |");
            Console.WriteLine("                                 |6. Quản lý khách hàng                             |");
            Console.WriteLine("                                 |0.Thoát                                           |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        public static void Run(SanPham_BLL sanPham_BLL)
        {
            int chon;
            sanPham_BLL.docFile();

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
                        string nhap;
                        while (true)
                        {

                            Console.Clear();
                            sanPham_BLL.Them();
                            Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                            Console.ReadLine();
                            Console.Clear();
                            Console.Write("                                 Bạn có muốn nhập tiếp không?C/K ");
                            nhap = Console.ReadLine();
                            if (nhap == "k" || nhap == "K")
                            {
                                Console.Clear();
                                break;

                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        sanPham_BLL.Xem();
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        sanPham_BLL.Sua();
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        sanPham_BLL.Xoa();
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        sanPham_BLL.TimKiem();
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:

                        Console.Clear();
                        KhachHang_GUI.Run(sanPham_BLL);
                        
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
