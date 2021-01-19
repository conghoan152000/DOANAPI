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
    public class TrangThaiController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public TrangThaiController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        //GET : api/TrangThai
        public async Task<ActionResult<IEnumerable<DM_TrangThai>>> getDatas()
        {
            return await _ThuVienHHTContext.DM_TrangThais.ToListAsync();
        }

        [HttpPost]
        //POST : api/TrangThai
        public async Task<ActionResult<DM_TrangThai>> ThemTrangThai([FromBody] DM_TrangThai DM_TrangThai)
        {
            _ThuVienHHTContext.DM_TrangThais.Add(DM_TrangThai);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { id = DM_TrangThai.Id }, DM_TrangThai);
        }
        [HttpDelete("{Id}")]
        //DELETE : api/TrangThai
        public async Task<ActionResult<DM_TrangThai>> DeleteTrangThai(int Id)
        {
            var TrangThai = await _ThuVienHHTContext.DM_TrangThais.FindAsync(Id);
            if (TrangThai == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.DM_TrangThais.Remove(TrangThai);
            await _ThuVienHHTContext.SaveChangesAsync();

            return TrangThai;
        }

        [HttpPut("{Id}")]
        //PUT : api/TrangThai
        public async Task<ActionResult<DM_TrangThai>> Update(int Id, [FromBody] DM_TrangThai DM_TrangThai)
        {
            if (Id != DM_TrangThai.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.DM_TrangThais.Update(DM_TrangThai);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
