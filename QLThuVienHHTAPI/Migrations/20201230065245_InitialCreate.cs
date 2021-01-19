using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLThuVienHHTAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Khoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhoa = table.Column<string>(nullable: false),
                    TenKhoa = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Khoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LoaiSach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiSach = table.Column<string>(nullable: false),
                    TenLoaiSach = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LoaiSach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TrangThai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTrangThai = table.Column<string>(nullable: false),
                    TenTrangThai = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TrangThai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DM_Phong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<string>(nullable: false),
                    TenPhong = table.Column<string>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true),
                    MaKhoa = table.Column<string>(nullable: false),
                    DM_KhoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Phong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DM_Phong_DM_Khoa_DM_KhoaId",
                        column: x => x.DM_KhoaId,
                        principalTable: "DM_Khoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DM_KeSach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKeSach = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ViTriKeSach = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MaTrangThai = table.Column<string>(nullable: false),
                    DM_TrangThaiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_KeSach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DM_KeSach_DM_TrangThai_DM_TrangThaiId",
                        column: x => x.DM_TrangThaiId,
                        principalTable: "DM_TrangThai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<string>(nullable: false),
                    HoTenSV = table.Column<string>(nullable: false),
                    GioiTinh = table.Column<string>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    QueQuan = table.Column<string>(nullable: false),
                    SDT = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phong = table.Column<string>(nullable: false),
                    Khoa = table.Column<string>(nullable: false),
                    DM_KhoaId = table.Column<int>(nullable: true),
                    DM_PhongId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhVien_DM_Khoa_DM_KhoaId",
                        column: x => x.DM_KhoaId,
                        principalTable: "DM_Khoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SinhVien_DM_Phong_DM_PhongId",
                        column: x => x.DM_PhongId,
                        principalTable: "DM_Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DM_Sach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSach = table.Column<string>(nullable: false),
                    TenSach = table.Column<string>(nullable: false),
                    TacGia = table.Column<string>(nullable: false),
                    GiaSach = table.Column<int>(nullable: false),
                    GiaMuon = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    Anh = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    MaKeSach = table.Column<string>(nullable: false),
                    MaLoaiSach = table.Column<string>(nullable: false),
                    MaTrangThai = table.Column<string>(nullable: false),
                    DM_TrangThaiId = table.Column<int>(nullable: true),
                    DM_LoaiSachId = table.Column<int>(nullable: true),
                    DM_KeSachId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Sach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DM_Sach_DM_KeSach_DM_KeSachId",
                        column: x => x.DM_KeSachId,
                        principalTable: "DM_KeSach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DM_Sach_DM_LoaiSach_DM_LoaiSachId",
                        column: x => x.DM_LoaiSachId,
                        principalTable: "DM_LoaiSach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DM_Sach_DM_TrangThai_DM_TrangThaiId",
                        column: x => x.DM_TrangThaiId,
                        principalTable: "DM_TrangThai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MuonTraSach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGianMuon = table.Column<DateTime>(nullable: false),
                    ThoiGianHenTra = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<int>(nullable: false),
                    DM_SachId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuonTraSach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuonTraSach_DM_Sach_DM_SachId",
                        column: x => x.DM_SachId,
                        principalTable: "DM_Sach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CT_MuonTraSach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Anh = table.Column<string>(nullable: true),
                    ThoiGianMuon = table.Column<DateTime>(nullable: false),
                    ThoiGianHenTra = table.Column<DateTime>(nullable: false),
                    ThoiGianTra = table.Column<DateTime>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaMuon = table.Column<int>(nullable: false),
                    NguoiTao = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MaTrangThai = table.Column<string>(nullable: false),
                    DM_TrangThaiId = table.Column<int>(nullable: false),
                    MaSach = table.Column<string>(nullable: false),
                    MaSinhVien = table.Column<string>(nullable: false),
                    SinhVienId = table.Column<int>(nullable: false),
                    DM_SachId = table.Column<int>(nullable: true),
                    MuonTraSachId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_MuonTraSach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CT_MuonTraSach_DM_Sach_DM_SachId",
                        column: x => x.DM_SachId,
                        principalTable: "DM_Sach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CT_MuonTraSach_MuonTraSach_MuonTraSachId",
                        column: x => x.MuonTraSachId,
                        principalTable: "MuonTraSach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CT_MuonTraSach_SinhVien_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "SinhVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CT_MuonTraSach_DM_SachId",
                table: "CT_MuonTraSach",
                column: "DM_SachId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_MuonTraSach_MuonTraSachId",
                table: "CT_MuonTraSach",
                column: "MuonTraSachId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_MuonTraSach_SinhVienId",
                table: "CT_MuonTraSach",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_DM_KeSach_DM_TrangThaiId",
                table: "DM_KeSach",
                column: "DM_TrangThaiId");

            migrationBuilder.CreateIndex(
                name: "IX_DM_Phong_DM_KhoaId",
                table: "DM_Phong",
                column: "DM_KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_DM_Sach_DM_KeSachId",
                table: "DM_Sach",
                column: "DM_KeSachId");

            migrationBuilder.CreateIndex(
                name: "IX_DM_Sach_DM_LoaiSachId",
                table: "DM_Sach",
                column: "DM_LoaiSachId");

            migrationBuilder.CreateIndex(
                name: "IX_DM_Sach_DM_TrangThaiId",
                table: "DM_Sach",
                column: "DM_TrangThaiId");

            migrationBuilder.CreateIndex(
                name: "IX_MuonTraSach_DM_SachId",
                table: "MuonTraSach",
                column: "DM_SachId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_DM_KhoaId",
                table: "SinhVien",
                column: "DM_KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_DM_PhongId",
                table: "SinhVien",
                column: "DM_PhongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CT_MuonTraSach");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MuonTraSach");

            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "DM_Sach");

            migrationBuilder.DropTable(
                name: "DM_Phong");

            migrationBuilder.DropTable(
                name: "DM_KeSach");

            migrationBuilder.DropTable(
                name: "DM_LoaiSach");

            migrationBuilder.DropTable(
                name: "DM_Khoa");

            migrationBuilder.DropTable(
                name: "DM_TrangThai");
        }
    }
}
