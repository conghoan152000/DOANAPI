using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName = "nvarchar(50)")]
        public string FullName { get; set; }

        //[Column(TypeName = "nvarchar(50)")]
        //public string TenKhongDau { get; set; }
        //[Column(TypeName = "nvarchar(50)")]
        //public string GioiTinh { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime NgaySinh { get; set; }
        //[Column(TypeName = "nvarchar(50)")]
        //public string QueQuan { get; set; }
        //[Column(TypeName = "nvarchar(50)")]
        //public string SDT { get; set; }
        //[Column(TypeName = "nvarchar(50)")]
        //public string Email { get; set; }
        //public string Anh { get; set; }
        //[Column(TypeName = "nvarchar(50)")]
        //public string MaPhong { get; set; }
        //public int Level { get; set; }
        //[Column(TypeName = "int")]
        //public int Active { get; set; }
    }
}