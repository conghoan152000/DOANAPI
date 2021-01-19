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
    public class SachController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public SachController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        //GET : api/Sach
        public async Task<ActionResult<IEnumerable<DM_Sach>>> getDatas()
        {
            return await _ThuVienHHTContext.DM_Saches.ToListAsync();
        }

        [HttpPost]
        //POST : api/Sach
        public async Task<ActionResult<DM_Sach>> ThemSach([FromBody] DM_Sach DM_Sach)
        {
            _ThuVienHHTContext.DM_Saches.Add(DM_Sach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { id = DM_Sach.Id }, DM_Sach);
        }
        [HttpDelete("{id}")]
        //DELETE : api/Sach
        public async Task<ActionResult<DM_Sach>> DeleteSach(int Id)
        {
            var Sach = await _ThuVienHHTContext.DM_Saches.FindAsync(Id);
            if (Sach == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.DM_Saches.Remove(Sach);
            await _ThuVienHHTContext.SaveChangesAsync();

            return Sach;
        }

        //[HttpPut("{id}")]
        //PUT : api/Sach
        //public async Task<ActionResult<DM_Sach>> Update(int Id, [FromBody] DM_Sach DM_Sach)
        //{
        //    if (Id != DM_Sach.Id)
        //    {
        //        return BadRequest();
        //    }
        //    _ThuVienHHTContext.DM_Saches.Update(DM_Sach);
        //    await _ThuVienHHTContext.SaveChangesAsync();
        //    return NoContent();
        //}

        [HttpPut("{id}")]
        public async Task<IActionResult> SuaThietBi(int id, [FromBody] DM_Sach DM_Sach)
        {
            if (id != DM_Sach.Id)
            {
                return BadRequest();
            }

            _ThuVienHHTContext.Entry(DM_Sach).State = EntityState.Modified;

            try
            {
                await _ThuVienHHTContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        private bool ProductExists(int id)
        {
            return _ThuVienHHTContext.DM_Saches.Any(e => e.Id == id);
        }
    }


}

