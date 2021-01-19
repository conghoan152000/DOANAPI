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
    public class MuonTraSachController : ControllerBase
    {
        public readonly ThuVienHHTContext _ThuVienHHTContext;
        public MuonTraSachController(ThuVienHHTContext thuVienHHTContext)
        {
            _ThuVienHHTContext = thuVienHHTContext;
        }


        [HttpGet]
        //GET : api/MuonTraSach
        public async Task<ActionResult<IEnumerable<MuonTraSach>>> getDatas()
        {
            return await _ThuVienHHTContext.MuonTraSaches.ToListAsync();
        }

        [HttpPost]
        //POST : api/MuonTraSach
        public async Task<ActionResult<MuonTraSach>> ThemMuonTra([FromBody] MuonTraSach MuonTraSach)
        {
            _ThuVienHHTContext.MuonTraSaches.Add(MuonTraSach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return CreatedAtAction("getDatas", new { id = MuonTraSach.Id }, MuonTraSach);
        }
        [HttpDelete("{Id}")]
        //DELETE : api/MuonTraSach
        public async Task<ActionResult<MuonTraSach>> DeleteMuonTra(int Id)
        {
            var MuonTra = await _ThuVienHHTContext.MuonTraSaches.FindAsync(Id);
            if (MuonTra == null)
            {
                return NotFound();
            }

            _ThuVienHHTContext.MuonTraSaches.Remove(MuonTra);
            await _ThuVienHHTContext.SaveChangesAsync();

            return MuonTra;
        }

        [HttpPut("{Id}")]
        //PUT : api/MuonTraSach
        public async Task<ActionResult<MuonTraSach>> Update(int Id, [FromBody] MuonTraSach MuonTraSach)
        {
            if (Id != MuonTraSach.Id)
            {
                return BadRequest();
            }
            _ThuVienHHTContext.MuonTraSaches.Update(MuonTraSach);
            await _ThuVienHHTContext.SaveChangesAsync();
            return NoContent();
        }



    }
}