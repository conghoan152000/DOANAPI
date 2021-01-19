using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class MuonTraSach
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        public DateTime ThoiGianMuon { get; set; }
        //[Required]
        public DateTime ThoiGianHenTra { get; set; }
        [Required]
        public int TongTien { get; set; }
        public DM_Sach DM_Sach { get; set; }
    }
}
