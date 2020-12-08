using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat.Entities
{
    class SanPham
    {
        //tạo các thuộc tính
        private string ten, diachi;
        private double dientich;
        private int sotang, sophong, gia;
        //tạo Contructor có tham số
        public SanPham(string ten,string diachi,double dientich,int sotang,int sophong,int gia)
        {
            this.Ten = ten;
            this.Diachi = diachi;
            this.Dientich = dientich;
            this.Sotang = sotang;
            this.Sophong = sophong;
            this.Gia = gia;
        }
        //tạo contructor không tham số
        public SanPham()
        {

        }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public double Dientich { get => dientich; set => dientich = value; }
        public int Sotang { get => sotang; set => sotang = value; }
        public int Sophong { get => sophong; set => sophong = value; }
        public int Gia { get => gia; set => gia = value; }
        // tạo get/set cho thuộc tính
        override
            //trả về chuỗi để xử lí file
            public string ToString()
        {
            return ten + "#" + diachi + "#" + dientich + "#" + sotang + "#" + sophong + "#" + gia;
        }

    }
}
