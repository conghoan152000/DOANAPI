using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThuVienHHTAPI.Models.BookManagement;

namespace QLThuVienHHTAPI.Models
{
    public class ThuVienHHTContext : IdentityDbContext
    {
        public ThuVienHHTContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers {get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<MuonTraSach> MuonTraSaches { get; set; }
        public DbSet<CT_MuonTraSach> CT_MuonTraSaches { get; set; }
        public DbSet<DM_KeSach> DM_KeSaches { get; set; }
        public DbSet<DM_Sach> DM_Saches { get; set; }
        public DbSet<DM_LoaiSach>DM_LoaiSaches { get; set; }
        public DbSet<DM_Khoa> DM_Khoas { get; set; }
        public DbSet<DM_Phong> DM_Phongs { get; set; }
        public DbSet<DM_TrangThai> DM_TrangThais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<SinhVien>().ToTable("SinhVien");
            modelbuilder.Entity<CT_MuonTraSach>().ToTable("CT_MuonTraSach");
            modelbuilder.Entity<MuonTraSach>().ToTable("MuonTraSach");
            modelbuilder.Entity<DM_KeSach>().ToTable("DM_KeSach");
            modelbuilder.Entity<DM_Khoa>().ToTable("DM_Khoa");
            modelbuilder.Entity<DM_Phong>().ToTable("DM_Phong");
            modelbuilder.Entity<DM_Sach>().ToTable("DM_Sach");
            modelbuilder.Entity<DM_TrangThai>().ToTable("DM_TrangThai");
            modelbuilder.Entity<DM_LoaiSach>().ToTable("DM_LoaiSach");

        }

    }

}
