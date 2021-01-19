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
    public class LoaiSachController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public LoaiSachController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }

        [HttpGet]
        //GET : api/LoaiSach
        public async Task<ActionResult<IEnumerable<DM_LoaiSach>>> getDatas()
        {
            return await _ThuVienHHTContext.DM_LoaiSaches.ToListAsync();
        }

        [HttpPost]
        //POST : api/LoaiSach
        public async Task<ActionResult<DM_LoaiSach>> ThemLoaiSach([FromBody] DM_LoaiSach DM_LoaiSach)
        {
            _ThuVienHHTContext.DM_LoaiSaches.Add(DM_LoaiSach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { Id = DM_LoaiSach.Id }, DM_LoaiSach);
        }

        [HttpDelete("{Id}")]
        //DELETE : api/LoaiSach
        public async Task<ActionResult<DM_LoaiSach>> DeleteLoaiSach(int Id)
        {
            var LoaiSach = await _ThuVienHHTContext.DM_LoaiSaches.FindAsync(Id);
            if (LoaiSach == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.DM_LoaiSaches.Remove(LoaiSach);
            await _ThuVienHHTContext.SaveChangesAsync();

            return LoaiSach;
        }

        [HttpPut("{Id}")]
        //PUT : api/LoaiSach
        public async Task<ActionResult<DM_LoaiSach>> Update(int Id, [FromBody] DM_LoaiSach DM_LoaiSach)
        {
            if (Id != DM_LoaiSach.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.DM_LoaiSaches.Update(DM_LoaiSach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
