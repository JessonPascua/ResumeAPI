namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CertificationController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public CertificationController(ResumeAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Certifications")]
        public async Task<ActionResult<IEnumerable<Certifications>>> GetCertifications()
        {
            var certificationList = await _context.Certifications.ToListAsync();

            if (certificationList == null || certificationList.Count == 0)
            {
                return NotFound();
            }
            return Ok(certificationList);
        }
    }
}
