using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLThuVienHHTAPI.Models.BookManagement
{
    public class CT_MuonTraSach
    {
        public int Id {get;set; }
        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string TenSach { get; set; }
        public string Anh { get; set; }
        [Required]
        public DateTime ThoiGianMuon { get; set; }
        [Required]
        public DateTime ThoiGianHenTra { get; set; }
        public DateTime ThoiGianTra { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public int GiaMuon { get; set; }
        public string NguoiTao {get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string GhiChu { get; set; }
        [Required]
        public string MaTrangThai { get; set; }
        public int DM_TrangThaiId { get; set; }
        [Required]
        public string MaSach { get; set; }
        [Required]
        public string MaSinhVien { get; set; }
        public int SinhVienId { get; set; }
        public SinhVien SinhVien { get; set; }
        public DM_Sach DM_Sach { get; set; }
        public MuonTraSach MuonTraSach {get;set; }
    }
}
