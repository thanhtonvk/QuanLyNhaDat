using QuanLyNhaDat.GUI;
using System;
using System.Collections;
using System.Text;

namespace QuanLyNhaDat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList taikhoan = new ArrayList();
            DangNhap_GUI.Chon(taikhoan);
        }
    }
}
