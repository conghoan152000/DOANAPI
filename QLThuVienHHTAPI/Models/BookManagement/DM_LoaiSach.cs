using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class DM_LoaiSach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MaLoaiSach { get; set; }
        [Required]
        public string TenLoaiSach { get; set; }
        public string GhiChu { get; set; }
    }
}
