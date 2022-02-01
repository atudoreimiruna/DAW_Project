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
    public class FeedbackController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FeedbackController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost("fromBody")]
        //[Authorize("Admin")]
        public async Task<IActionResult> CreateDesigner(FeedbackPostModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                return BadRequest("Invalid object. Model is null");
            }

            var feedback = new Feedback()
            {
                Name = model.Name,
                Message = model.Message
            };

            await _context.Feedbacks.AddRangeAsync(feedback);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
