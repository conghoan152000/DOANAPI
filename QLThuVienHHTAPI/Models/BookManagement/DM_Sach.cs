using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class DM_Sach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MaSach { get; set; }
        [Required]
        public string TenSach { get; set; }
        [Required]
        public string TacGia { get; set; }
        [Required]
        public int GiaSach { get; set; }
        [Required]
        public int GiaMuon { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        [Required]
        public string MaKeSach { get; set; }
        [Required]
        public string MaLoaiSach { get; set; }
        [Required]
        public string MaTrangThai { get; set; }
        public DM_TrangThai DM_TrangThai { get; set; }
        public DM_LoaiSach DM_LoaiSach { get; set; }
        public DM_KeSach DM_KeSach { get; set; }
    }
}
