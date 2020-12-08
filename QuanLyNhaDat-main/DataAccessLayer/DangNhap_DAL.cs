using QuanLyNhaDat.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyNhaDat.Entities;

namespace QuanLyNhaDat.DAL
{
    class DangNhap_DAL
    {
        public static void docFile(ArrayList list)
        {
            if (File.Exists("dangnhap.txt"))
            {
                StreamReader streamReader = new StreamReader("dangnhap.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(new DangNhap(line.Split("#")[0], line.Split("#")[1]));
                }
                streamReader.Close();
            }
        }

        public static void ghiFile(ArrayList list)
        {
            StreamWriter streamWriter = new StreamWriter("dangnhap.txt");
            foreach (DangNhap dangNhap in list)
            {
                streamWriter.WriteLine(dangNhap.ToString());
            }
            streamWriter.Close();
        }
    }
}
