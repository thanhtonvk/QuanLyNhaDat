using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat.Entities
{
    class DangNhap
    {
        //tạo các thuộc tính cho đốitượng đăng nhập
        private string user;
        private string password;
        //tạo contructor có tham số
        public DangNhap(string user,string password)
        {
            this.User = user;
            this.Password = password;
        }//tạo contructor không tham số
        public DangNhap()
        {

        }
        //tạo get/set cho thuộc tính
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        override
            public string ToString()
        {
            return user + "#" + password;
        }
    }
}
