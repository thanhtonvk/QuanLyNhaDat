using QuanLyNhaDat.DAL;
using QuanLyNhaDat.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat.BLL.Interface
{
    class SanPham_BLL : ISanPham
    {
        //tạo 1 mảng để lưu danh sách nhà đất
        static ArrayList list = new ArrayList();
        static SanPham_DAL sanPham_DAL = new SanPham_DAL();
        static KhachHang_DAL khachHang_DAL = new KhachHang_DAL();
        static ArrayList list_kh = new ArrayList();
        public void docFile()
        {
           
            sanPham_DAL.docFile(list);
            khachHang_DAL.docFile(list_kh);
        }
      
        public string Nhapten()
        {
            string str = Console.ReadLine();
            int dem=0;
            while (true)
            {
                if (str != ""||dem==3) break;
                else
                {
                    dem++;
                    Console.Write("                                 Phải nhập khác rỗng: ");
                    str = Console.ReadLine();
                  
                }
            }
            return str;
        }
        public void nhapKhachHang()
        {

            //string ten,string diachi,string sdt,string tensanphammua,int sotiencoc
            Console.Write("                                 Nhập tên khách hàng: ");
            string ten = Nhapten();
            Console.Write("                                 NHập địa chỉ: ");
            string diachi = Nhapten();
            Console.Write("                                 Nhập sđt: ");
            string sdt = Nhapten();
            string tensanphammua="";
            bool kt = true;
            while (kt)
            {
                Console.Write("                                 Nhập tên sản phẩm mua: ");
                tensanphammua = Nhapten();
                foreach (SanPham sanPham in list)
                {
                    if (sanPham.Ten.Equals(tensanphammua)) kt = false;
                }

            }
            Console.Write("                                 Nhập số tiền cọc: ");
            int sotiencoc = int.Parse(Console.ReadLine());
            list_kh.Add(new KhachHang(ten, diachi, sdt, tensanphammua, sotiencoc));
            khachHang_DAL.ghiFile(list_kh);
        }
        public double getGiaNha(string tenspmua)
        {
            double gia=0;
            foreach(SanPham sanPham in list)
            {
                if (sanPham.Ten.Equals(tenspmua))
                {
                    gia = sanPham.Gia;
                }
            }
            return gia;
        }
        public void hienKhachHang()
        {
            Console.WriteLine("                                 |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Tên", "Địa chỉ", "Sđt", "Tên sản phẩm mua", "Số tiền cọc", "Giá bán");
            //duyệt sản phẩm trong danh sách
            foreach (KhachHang khachHang in list_kh)
            {
                Console.WriteLine("                                 |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", khachHang.Ten,khachHang.Diachi,khachHang.Sdt,khachHang.Tensanphammua,khachHang.Sotiencoc,getGiaNha(khachHang.Tensanphammua));
            }
        }

        public void Sua()
        {
            Console.WriteLine("                                 Nhập tên nhà cần sửa: ");
            string tukhoa = Console.ReadLine();
            bool kt = false;
            //duyệt danh sách
            foreach (SanPham sanPham in list)
            {
                //nếu đối tượng tìm thấy thì tiến hành sửa thông tin
                if (sanPham.Ten.Equals(tukhoa))
                {
                    kt = true;
                    Console.Write("                                 Nhập tên nhà:");
                    sanPham.Ten = Nhapten();
                    Console.Write("                                 Nhập địa chỉ: ");
                    sanPham.Diachi = Nhapten();
                    Console.Write("                                 Nhập diện tích: ");
                    sanPham.Dientich = double.Parse(Console.ReadLine());
                    Console.Write("                                 Nhập số tầng: ");
                    sanPham.Sotang = int.Parse(Console.ReadLine());
                    Console.Write("                                 Nhập số phòng: ");
                    sanPham.Sophong = int.Parse(Console.ReadLine());
                    Console.Write("                                 Nhập giá bán: ");
                    sanPham.Gia = int.Parse(Console.ReadLine());
                    Console.Write("                                 sửa thông tin thành công");
                    sanPham_DAL.ghiFile(list);
                }
            }
            if (kt == false) Console.WriteLine("                                 Không tìm thấy nhà");
        }

        public void Them()
        {
            //Nhập thông tin của nhà đất
            Console.Write("                                 Nhập tên nhà: ");
            string ten = Nhapten();
            Console.Write("                                 Nhập địa chỉ: ");
            string diachi = Nhapten();
            Console.Write("                                 Nhập diện tích: ");
            double dientich = double.Parse(Nhapten());
            Console.Write("                                 Nhập số tầng: ");
            int sotang = int.Parse(Nhapten());
            Console.Write("                                  số phòng: ");
            int sophong = int.Parse(Nhapten());
            Console.Write("                                 Nhập giá bán: ");
            int giaban = int.Parse(Nhapten());
            //thêm sản phẩm vừa  nhập vào danh sách
            list.Add(new SanPham(ten, diachi, dientich, sotang, sophong, giaban));
            sanPham_DAL.ghiFile(list);
        }

        public void TimKiem()
        {
            Console.Write("                                 Nhập tên nhà cần tìm: ");
            string tukhoa = Nhapten();
            bool kt = false;
            //duyệt danh sách
            Console.WriteLine("                                 |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Tên", "Địa chỉ", "Diện tích", "Số tầng", "Số phòng", "Giá bán");
            foreach (SanPham sanPham in list)
            {
                //nếu đối tượng tìm thấy thì tiến hành hiện thông tin
                if (sanPham.Ten.Equals(tukhoa))
                {
                    
                    //hiện thông tin
                    Console.WriteLine("                                 |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}{5,-20}|", sanPham.Ten, sanPham.Diachi, sanPham.Dientich, sanPham.Sotang, sanPham.Sophong, sanPham.Gia);
                    kt = true;
                }
            }
            if (kt == false) Console.WriteLine("                                 Không tìm thấy nhà");
        }

        public void Xem()
        {
            Console.WriteLine("                                 |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Tên", "Địa chỉ", "Diện tích", "Số tầng", "Số phòng", "Giá bán");
            //duyệt sản phẩm trong danh sách
            foreach (SanPham sanPham in list)
            {
                Console.WriteLine("                                 |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", sanPham.Ten, sanPham.Diachi, sanPham.Dientich, sanPham.Sotang, sanPham.Sophong, sanPham.Gia);
            }
        }

        public void Xoa()
        {
            Console.Write("                                 Nhập tên nhà cần xóa: ");
            string tukhoa = Console.ReadLine();
            bool kt = false;
            //duyệt danh sách
            foreach (SanPham sanPham in list)
            {
                //nếu đối tượng tìm thấy thì tiến hành xóa
                if (sanPham.Ten.Equals(tukhoa))
                {
                    list.Remove(sanPham);
                    kt = true;
                    sanPham_DAL.ghiFile(list);
                    break;
                }

            }
            if (kt == false) Console.WriteLine("                                 Không tìm thấy nhà");
        }
    }
}

