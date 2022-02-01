using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect1.DAL;
using Proiect1.DAL.Entities;
using Proiect1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Proiect1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CollectionsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize("Admin")]
        public async Task<IActionResult> CreateCollection(CollectionPostModel model)
        {
            if (string.IsNullOrEmpty(model.CollectionName))
            {
                return BadRequest("Invalid object. Model is null");
            }

            var collection = new Collection()
            {
                CollectionName = model.CollectionName,
                NumberOfItems = model.NumberOfItems,
                ReleaseDate = model.ReleaseDate
            };

            await _context.Collections.AddRangeAsync(collection);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // Get All
        [HttpGet("")]
        // [Authorize("Admin")]
        // [Authorize("Designer")]
        public async Task<IActionResult> GetAllCollections()
        {
            var collections = await _context.Collections.OrderBy(x => x.CollectionName).ToListAsync();

            return Ok(collections);
        }

        
        // Get by Id
        [HttpGet("byId/{id}")]
        public async Task<IActionResult> GetCollections([FromRoute] int id) // id ul este pt designer
        {
            var collections = from c in _context.Collections
                              join a in _context.DesignerCollections on c.Id equals a.CollectionId
                              join b in _context.Designers on a.DesignerId equals b.Id
                              where (c.Id == a.CollectionId) && (a.DesignerId == b.Id) && (id == b.Id)
                              select new { c.Id, c.CollectionName, c.NumberOfItems, c.ReleaseDate };

            return Ok(collections);
        }

        


        // Update - facem update la numele unei colectii
        [HttpPut] 
        [Authorize("Admin")]
        public async Task<IActionResult> Update([FromQuery] int id, [FromQuery] string nume)
        {
            var collection = await _context
                .Collections
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            collection.CollectionName = nume;   // numele dat de noi

            _context.Entry(collection).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            var collectionV2 = await _context
                .Collections
                .FirstOrDefaultAsync(x => x.Id == id);

            return Ok();
        }

        //Delete - stergem colectiile cu nr maxim de item-uri 
        [HttpDelete]
        [Authorize("Admin")]
        public async Task<IActionResult> DeleteCollection()
        {
            var maxx = _context.Collections.Max(x => x.NumberOfItems);

            var collections = await _context
                .Collections
                .Where(x => x.NumberOfItems == maxx)
                .ToListAsync();

            if (collections == null)
            {
                return NotFound("Collections not found");
            }
            foreach (var c in collections)
            {
                _context.Collections.Remove(c);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }

    }
}
