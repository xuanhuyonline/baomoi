using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _2001190568_LeXuanHuy_KTL1.Models
{
    public class User
    {
        [Required()]
        public string Ten { get; set; }

        [Required()]
        public string Email { get; set; }

        [Required()]
        [StringLength(255, ErrorMessage = "Must be between 6 and 255 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required()]
        public string GioiTinh { get; set; }

        [Required()]
        public string NgheNghiep { get; set; }
    }
}