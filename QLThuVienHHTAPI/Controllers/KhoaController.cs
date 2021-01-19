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
    public class KhoaController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public KhoaController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        //GET : api/Khoa
        public async Task<ActionResult<IEnumerable<DM_Khoa>>> getDatas()
        {
            return await _ThuVienHHTContext.DM_Khoas.ToListAsync();
        }

        [HttpPost]
        //POST : api/Khoa
        public async Task<ActionResult<DM_Khoa  >> ThemKhoa([FromBody] DM_Khoa DM_Khoa)
        {
            _ThuVienHHTContext.DM_Khoas.Add(DM_Khoa);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { id = DM_Khoa.Id }, DM_Khoa);
        }
        [HttpDelete("{Id}")]
        //DELETE : api/Khoa
        public async Task<ActionResult<DM_Khoa>> DeleteKhoa(int Id)
        {
            var Khoa = await _ThuVienHHTContext.DM_Khoas.FindAsync(Id);
            if (Khoa == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.DM_Khoas.Remove(Khoa);
            await _ThuVienHHTContext.SaveChangesAsync();

            return Khoa;
        }

        [HttpPut("{Id}")]
        //PUT : api/Khoa
        public async Task<ActionResult<DM_Khoa>> Update(int Id, [FromBody] DM_Khoa DM_Khoa)
        {
            if (Id != DM_Khoa.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.DM_Khoas.Update(DM_Khoa);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
