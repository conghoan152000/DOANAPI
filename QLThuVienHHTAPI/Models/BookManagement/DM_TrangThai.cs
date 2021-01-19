using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class DM_TrangThai
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MaTrangThai { get; set; }
        [Required]
        public string TenTrangThai { get; set; }
        public string GhiChu { get; set; }
        [Required]
        public string Active { get; set; }
    }
}
