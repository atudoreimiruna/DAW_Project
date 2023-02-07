using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect1.DAL;
using Proiect1.DAL.Entities;
using Proiect1.DAL.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AwardsController(AppDbContext context)
        {
            _context = context;
        }

        // Post 
        [HttpPost]
        // [Authorize("Admin")]
        public async Task<IActionResult> CreateAward(AwardPostModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                return BadRequest("Invalid object. Model is null");
            }

            var award = new DesignerAward()
            {
                Name = model.Name,
                Contest = model.Contest,
                Data = model.Data,
                DesignerId = model.DesignerId
            };

            await _context.DesignerAwards.AddRangeAsync(award);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // Get All
        [HttpGet("")]
       // [Authorize("Admin")]
       // [Authorize("Designer")]
        public async Task<IActionResult> GetAllAwards()
        {
            var awards = await _context.DesignerAwards.OrderBy(x => x.Name).ToListAsync();

            return Ok(awards);
        }

        // Get by id
        [HttpGet("byId/{id}")]
        // [Authorize("Admin")]
        // [Authorize("Designer")]
        public async Task<IActionResult> GetAwards([FromRoute] int id)
        {
            //var designer= await _context.Designers.FindAsync(id);
            var awards = await _context.DesignerAwards.Where(x => x.DesignerId == id).ToListAsync();

            return Ok(awards);
        }

        // Get-join - afisam premiile detinute doar de designeri de sex feminin
        [HttpGet("get-join")]
        // [Authorize("Admin")]
        // [Authorize("Designer")]
        public async Task<IActionResult> GetDesignerAwardJoin()
        {
            var awards = await _context
                .DesignerAwards
                .Include(x => x.Designer)
                .Where(x => x.Designer.Gender == "F")
                .ToListAsync();

            return Ok(awards);
        }

        // Put - update la numele unui premiu
        [HttpPut]
        //[Authorize("Admin")]
        public async Task<IActionResult> Update([FromQuery] int id, [FromQuery] string name)
        {
            var award = await _context.DesignerAwards.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            award.Name = name; // numele introdus de noi

            _context.Entry(award).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            var awardV2 = await _context.DesignerAwards.FirstOrDefaultAsync(x => x.Id == id);

            return Ok();
        }

        // Delete - Stergem premiile luate la un anumit concurs
        [HttpDelete]
        //[Authorize("Admin")]
        public async Task<IActionResult> DeleteAward([FromQuery] string nume)
        {
            var awards= await _context
                .DesignerAwards
                .Where(x => x.Contest == nume)
                .ToListAsync();

            if (awards == null)
            {
                return NotFound($"Award with Name = {nume} not found");
            }

            foreach (var aw in awards)
            {
                _context.DesignerAwards.Remove(aw);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }
    }
}
