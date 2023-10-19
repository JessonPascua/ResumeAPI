namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public EducationController(ResumeAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Educations")]
        public async Task<ActionResult<IEnumerable<Educations>>> GetEducations()
        {
            var educationList = await _context.Educations.ToListAsync();

            if (educationList == null || educationList.Count == 0)
            {
                return NotFound();
            }
            return Ok(educationList);
        }
    }
}
