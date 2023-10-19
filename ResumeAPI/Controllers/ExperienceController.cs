using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeAPI.Data;
using ResumeAPI.Models;

namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public ExperienceController(ResumeAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Experiences")]
        public async Task<ActionResult<IEnumerable<Experiences>>> GetExperiences()
        {
            var experienceList = await _context.Experiences.ToListAsync();

            if (experienceList == null || experienceList.Count == 0)
            {
                return NotFound();
            }
            return Ok(experienceList);
        }
    }
}
