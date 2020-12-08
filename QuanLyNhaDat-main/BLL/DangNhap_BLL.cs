using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat.DAL;
using QuanLyNhaDat.Entities;

namespace QuanLyNhaDat.BLL
{
    class DangNhap_BLL
    {
        public static void TaoTK(ArrayList list)
        {
            //tạo tải khoản
            string tk = UserName();
            string mk = Password();
            //ghi tài khoản vào danh sách mảng
            list.Add(new DangNhap(tk, mk));
            //ghi tài khoản vào cơ sở dữ liệu
            DangNhap_DAL.ghiFile(list);
        }
        public static bool DangNhap(ArrayList list)
        {
            bool kt = false;
            //đọc tài khoản trong cơ sở dữ liệu
            DangNhap_DAL.docFile(list);
            string tk = UserName();
            string mk = Password();
            foreach (DangNhap dangnhap in list)
            {
                if (tk.Equals(dangnhap.User) && mk.Equals(dangnhap.Password))
                {
                    kt = true;
                }
            }
            return kt;
        }
        public static string UserName()
        {
            string tk;
            while (true)
            {
                Console.Write("                                 Nhập tài khoản: ");
                tk = Console.ReadLine();
                if (tk != "") break;
            }
            return tk;
        }
        public static string Password()
        {
            string pass;
            while (true)
            {
                Console.Write("                                 Nhập mật khẩu: ");
                pass = Console.ReadLine();
                if (pass != "") break;
            }
            return pass;
        }
    }
}

