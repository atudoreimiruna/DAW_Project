using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect1.DAL;
using Proiect1.DAL.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FactoriesController(AppDbContext context)
        {
            _context = context;
        }

        // Post 
        [HttpPost]
        // [Authorize("Admin")]
        public async Task<IActionResult> CreateFactory(FactoryPostModel model)
        {
            if (string.IsNullOrEmpty(model.FactoryName))
            {
                return BadRequest("Invalid object. Model is null");
            }

            var factory = new DAL.Entities.CollectionFactory()
            {
                FactoryName = model.FactoryName,
                Contact = model.Contact,
                FactoryAddress = model.FactoryAddress,
                CollectionId = model.CollectionId
            };

            await _context.CollectionFactories.AddRangeAsync(factory);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // Get-order-by - afiseaza fabricile in ordine alfabetica 
        [HttpGet]
        // [Authorize("Admin")]
        // [Authorize("Designer")]
        public async Task<IActionResult> GetFactories()
        {
            var factories = await _context
                .CollectionFactories
                .OrderBy(x => x.FactoryName)
                .ToListAsync();

            return Ok(factories);
        }
  
        // Update - facem update la adresa unui atelier
        [HttpPut]
        // [Authorize("Admin")]
        public async Task<IActionResult> Update([FromQuery] int id, [FromQuery] string address)
        {
            var factory = await _context
                .CollectionFactories
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            factory.FactoryAddress = address; // adresa introdusa de noi

            _context.Entry(factory).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            var factoryV2 = await _context
                .CollectionFactories
                .FirstOrDefaultAsync(x => x.Id == id);

            return Ok();
        }

        // Delete -- stergem o fabrica dupa id
        [HttpDelete]
        // [Authorize("Admin")]
        public async Task<IActionResult> DeleteFactory(int id)
        {
            var factory = await _context
                .CollectionFactories
                .FirstOrDefaultAsync(x => x.Id == id);

            if (factory == null)
            {
                return NotFound($"Factory with Id = {id} not found");
            }

            _context.CollectionFactories.Remove(factory);

            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
