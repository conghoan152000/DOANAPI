using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class SinhVien
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MaSV { get; set; }
        [Required]
        public string HoTenSV { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public DateTime NgaySinh { get; set; }
        [Required]
        public string QueQuan { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phong { get; set; }
        [Required]
        public string Khoa { get; set; }
        public DM_Khoa DM_Khoa { get; set; }
        public DM_Phong DM_Phong { get; set; }
        }
}
