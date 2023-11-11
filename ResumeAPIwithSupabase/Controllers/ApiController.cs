//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using ResumeAPIwithSupabase.Models;

//namespace ResumeAPI.Controllers
//{
//    [Route("api")]
//    [ApiController]
//    public class ApiController : ControllerBase
//    {
//        private readonly Supabase.Client _context;

//        public ApiController(Supabase.Client context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Api>>> GetAllRoutes()
//        {
//            if (_context.Api == null)
//            {
//                return NotFound();
//            }
//            var routes = await _context.Api.Include(x => x.RoutesList).ToListAsync();

//            return Ok(routes);
//        }
//    }
//}
