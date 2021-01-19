using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class DM_Khoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MaKhoa { get; set; }
        [Required]
        public string TenKhoa { get; set; }
        public string GhiChu { get; set; }
    }
}
