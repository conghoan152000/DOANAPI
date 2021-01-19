using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class DM_KeSach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName= "nvarchar(50)")]
        public string MaKeSach { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ViTriKeSach { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string GhiChu { get; set; }
        [Required]  
        public string MaTrangThai { get; set; }
        public DM_TrangThai DM_TrangThai {get; set; }


    }
}
