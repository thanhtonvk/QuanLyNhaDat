using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat.Entities
{
    class KhachHang
    {
        //STT, tên, địa chỉ, sdt, tên sản phẩm mua, số tiền cọc, giá tiền
        private string ten, diachi, sdt, tensanphammua;
        private int sotiencoc;
        public KhachHang(string ten,string diachi,string sdt,string tensanphammua,int sotiencoc)
        {
            this.Ten = ten;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Tensanphammua = tensanphammua;
            this.Sotiencoc = sotiencoc;
        }
        override
            public string ToString()
        {
            return ten + "#" + diachi + "#" + sdt + "#" + tensanphammua + "#" + sotiencoc;
        }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Tensanphammua { get => tensanphammua; set => tensanphammua = value; }
        public int Sotiencoc { get => sotiencoc; set => sotiencoc = value; }
    }
}
