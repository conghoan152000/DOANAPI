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
    public class PhongController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public PhongController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        //GET : api/Phong
        public async Task<ActionResult<IEnumerable<DM_Phong >>> getDatas()
        {
            return await _ThuVienHHTContext.DM_Phongs.ToListAsync();
        }

        [HttpPost]
        //POST : api/Phong
        public async Task<ActionResult<DM_Phong>> ThemPhong([FromBody] DM_Phong DM_Phong)
        {
            _ThuVienHHTContext.DM_Phongs.Add(DM_Phong);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { id = DM_Phong.Id }, DM_Phong);
        }
        [HttpDelete("{Id}")]
        //DELETE : api/Phong
        public async Task<ActionResult<DM_Phong>> DeletePhong(int Id)
        {
            var Phong = await _ThuVienHHTContext.DM_Phongs.FindAsync(Id);
            if (Phong == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.DM_Phongs.Remove(Phong);
            await _ThuVienHHTContext.SaveChangesAsync();

            return Phong;
        }

        [HttpPut("{Id}")]
        //PUT : api/Phong
        public async Task<ActionResult<DM_Phong>> Update(int Id, [FromBody] DM_Phong DM_Phong)
        {
            if (Id != DM_Phong.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.DM_Phongs.Update(DM_Phong);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
