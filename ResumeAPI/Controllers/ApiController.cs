//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public ApiController(ResumeAPIContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Api>>> GetAllRoutes()
        //{
        //    if (_context.Api == null)
        //    {
        //        return NotFound();
        //    }
        //    var routes = await _context.Api.Include(x => x.Routes).ToListAsync();

        //    return Ok(routes);
        //}
    }
}
