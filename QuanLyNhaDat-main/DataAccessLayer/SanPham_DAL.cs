using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat.DAL.Interface;
using System.IO;
using QuanLyNhaDat.Entities;

namespace QuanLyNhaDat.DAL
{
    class SanPham_DAL : ISanPham
    {
        public void docFile(ArrayList list)
        {
            //nếu file đã tồn tại
            if (File.Exists("sanpham.txt"))
            {
                //tạo luồng đọc file
                StreamReader streamReader = new StreamReader("sanpham.txt");
                //(string ten, string diachi, double dientich, int sotang, int sophong, int gia)
                string line;
                //đọc từng dòng đến khi hết
                while((line= streamReader.ReadLine()) != null)
                {
                    //tách chuỗi
                    string ten = line.Split("#")[0];
                    string diachi = line.Split("#")[1];
                    double dientich = double.Parse(line.Split("#")[2]);
                    int sotang = int.Parse(line.Split("#")[3]);
                    int sophong = int.Parse(line.Split("#")[4]);
                    int gia = int.Parse(line.Split("#")[5]);
                    //lưu những đối tượng đọc ở trong file vào danh sách
                    list.Add(new SanPham(ten, diachi, dientich, sotang, sophong, gia));
                }
                streamReader.Close();
            }
        }

        public void ghiFile(ArrayList list)
        {
            //tạo luồng ghi file
            StreamWriter streamWriter = new StreamWriter("sanpham.txt");
            //duyệt danh sách sản phẩm
            foreach(SanPham sanpham in list)
            {
                //ghi vào file
                streamWriter.WriteLine(sanpham.ToString());
            }
            //đóng luồng
            streamWriter.Close();
        }
    }
}
