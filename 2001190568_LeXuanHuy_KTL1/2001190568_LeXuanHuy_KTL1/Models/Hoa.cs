using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2001190568_LeXuanHuy_KTL1.Models
{
    public class Hoa
    {
        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public string Anh { get; set; }

        public Hoa(string name, int pri, string image)
        {
            TenSanPham = name;
            Gia = pri;
            Anh = image;
        }
    }
}