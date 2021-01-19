using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLThuVienHHTAPI.Models;
using QLThuVienHHTAPI.Models.BookManagement;

namespace QLThuVienHHTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public SinhVienController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<SinhVien>>> getDatas()
        {
            return await _ThuVienHHTContext.SinhViens.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<SinhVien>> ThemSinhVien([FromBody] SinhVien SinhVien)
        {
            _ThuVienHHTContext.SinhViens.Add(SinhVien);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { Id = SinhVien.Id }, SinhVien);
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<SinhVien>> DeleteSinhVien(int Id)
        {
            var SinhVien = await _ThuVienHHTContext.SinhViens.FindAsync(Id);
            if (SinhVien == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.SinhViens.Remove(SinhVien);
            await _ThuVienHHTContext.SaveChangesAsync();

            return SinhVien;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<SinhVien>> Update(int Id, [FromBody] SinhVien SinhVien)
        {
            if (Id != SinhVien.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.SinhViens.Update(SinhVien);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
