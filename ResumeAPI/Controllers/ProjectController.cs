namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public ProjectController(ResumeAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Projects")]
        public async Task<ActionResult<IEnumerable<Projects>>> GetProjects()
        {
            var projectList = await _context.Projects.ToListAsync();

            if (projectList == null || projectList.Count == 0)
            {
                return NotFound();
            }
            return Ok(projectList);
        }
    }
}
