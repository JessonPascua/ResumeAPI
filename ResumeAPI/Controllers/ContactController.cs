namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public ContactController(ResumeAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Contacts")]
        public async Task<ActionResult<IEnumerable<Contacts>>> GetContacts()
        {
            var contactList = await _context.Contacts.ToListAsync();

            if (contactList == null || contactList.Count == 0)
            {
                return NotFound();
            }
            return Ok(contactList);
        }
    }
}
