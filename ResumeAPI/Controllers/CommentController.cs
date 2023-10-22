namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public CommentController(ResumeAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Comments")]
        public async Task<ActionResult<IEnumerable<Comments>>> GetComments()
        {
            var commentList = await _context.Comments.ToListAsync();

            if (commentList == null || commentList.Count == 0)
            {
                return NotFound();
            }
            return Ok(commentList);
        }

        [HttpPost]
        [Route("PostComments")]
        public async Task<ActionResult<Resume>> PostComment([Bind("Name, Email, Message")] Comments comment)
        {
            var defaultResume = await _context.Resume.FirstOrDefaultAsync();
            if (defaultResume == null)
            {
                return BadRequest("No default Resume found.");
            }

            comment.ResumeId = defaultResume.Id;
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Comments", new { id = comment.CommentId }, comment);
        }
    }
}
