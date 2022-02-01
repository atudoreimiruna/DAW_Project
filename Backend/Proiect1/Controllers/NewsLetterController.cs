using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class NewsLetterController : ControllerBase
    {

        private readonly AppDbContext _context;

        public NewsLetterController(AppDbContext context)
        {
            _context = context;
        }
        

        [HttpPost("fromBody")]
        //[Authorize("Admin")]
        public async Task<IActionResult> CreateNewsLetter(NewsLetterPostModel model)
        {
            if (string.IsNullOrEmpty(model.Email))
            {
                return BadRequest("Invalid object. Model is null");
            }

            var abonat = new NewsLetter()
            {
                Email = model.Email
            };

            await _context.NewsLetters.AddRangeAsync(abonat);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
