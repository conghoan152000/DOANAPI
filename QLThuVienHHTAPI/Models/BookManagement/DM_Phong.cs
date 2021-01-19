using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class DM_Phong
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MaPhong { get; set; }
        [Required]
        public string TenPhong { get; set; }
        public string GhiChu { get; set; }
        [Required]
        public string MaKhoa { get; set; }
        public DM_Khoa DM_Khoa { get; set; }
    }
}
