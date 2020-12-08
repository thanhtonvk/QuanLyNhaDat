using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyNhaDat.DAL.Interface;
using QuanLyNhaDat.Entities;
namespace QuanLyNhaDat.DAL
{
    class KhachHang_DAL : ISanPham
    {
        public void docFile(ArrayList list)
        {
            if (File.Exists("khachhhang.txt"))
            {
                //tạo luồng đọc file
                StreamReader streamReader = new StreamReader("khachhang.txt");
                //string ten,string diachi,string sdt,string tensanphammua,int sotiencoc
                string line;
                //đọc từng dòng đến khi hết
                while ((line = streamReader.ReadLine()) != null)
                {
                    //tách chuỗi
                    string ten = line.Split("#")[0];
                    string diachi = line.Split("#")[1];
                    string sdt = line.Split("#")[2];
                    string tensanphammua = line.Split("#")[3];
                    int tiencoc = int.Parse(line.Split("#")[4]);
                    //lưu những đối tượng đọc ở trong file vào danh sách
                    list.Add(new KhachHang(ten, diachi, sdt, tensanphammua, tiencoc));
                }
                streamReader.Close();
            }

        }

        public void ghiFile(ArrayList list)
        { //tạo luồng ghi file
            StreamWriter streamWriter = new StreamWriter("khachhang.txt");
            //duyệt danh sách sản phẩm
            foreach (KhachHang khachHang in list)
            {
                //ghi vào file
                streamWriter.WriteLine(khachHang.ToString());
            }
            //đóng luồng
            streamWriter.Close();

        }
    }
}
