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
    public class KeSachController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public KeSachController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        //GET : api/KeSach
        public async Task<ActionResult<IEnumerable<DM_KeSach>>> getDatas()
        {
            return await _ThuVienHHTContext.DM_KeSaches.ToListAsync();
        }

        [HttpPost]
        //Posto : api/KeSach
        public async Task<ActionResult<DM_KeSach>> ThemKeSach([FromBody] DM_KeSach DM_KeSach)
        {
            _ThuVienHHTContext.DM_KeSaches.Add(DM_KeSach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { id = DM_KeSach.Id }, DM_KeSach);
        }
        [HttpDelete("{Id}")]
        //DELETE : api/KeSach
        public async Task<ActionResult<DM_KeSach>> DeleteKeSach(int Id)
        {
            var KeSach = await _ThuVienHHTContext.DM_KeSaches.FindAsync(Id);
            if (KeSach == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.DM_KeSaches.Remove(KeSach);
            await _ThuVienHHTContext.SaveChangesAsync();

            return KeSach;
        }

        [HttpPut("{Id}")]
        //PUT : api/KeSach
        public async Task<ActionResult<DM_KeSach>> Update(int Id, [FromBody] DM_KeSach DM_KeSach)
        {
            if (Id != DM_KeSach.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.DM_KeSaches.Update(DM_KeSach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
