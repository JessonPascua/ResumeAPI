using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace ResumeAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly ResumeAPIContext _context;

        public ResumeController(ResumeAPIContext context)
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
        //    return Ok(await _context.Api.Include(x => x.routes)
        //                                   .ToListAsync());
        //}

        // GET: api/Resume
        [HttpGet]
        [Route("Resume")]
        public async Task<ActionResult<IEnumerable<Resume>>> GetResume()
        {
            if (_context.Resume == null)
            {
                return NotFound();
            }
            return Ok(await _context.Resume.Include(x => x.Experiences)
                                           .Include(x => x.Educations)
                                           .Include(x => x.Certifications)
                                           .Include(x => x.Projects)
                                           .Include(x => x.Contacts)
                                           .Include(x => x.Comments)
                                           .ToListAsync());
        }


        //[HttpGet]
        //[Route("Certifications")]
        //public async Task<ActionResult<IEnumerable<Resume>>> GetCertifications()
        //{
        //    var certificationList = await _context.Certifications.ToListAsync();

        //    if (certificationList == null || certificationList.Count == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(certificationList);
        //}

        //[HttpGet]
        //[Route("Projects")]
        //public async Task<ActionResult<IEnumerable<Resume>>> GetProjects()
        //{
        //    var projectList = await _context.Projects.ToListAsync();

        //    if (projectList == null || projectList.Count == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(projectList);
        //}

        //[HttpGet]
        //[Route("Contacts")]
        //public async Task<ActionResult<IEnumerable<Resume>>> GetContacts()
        //{
        //    var contactList = await _context.Contacts.ToListAsync();

        //    if (contactList == null || contactList.Count == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(contactList);
        //}

        //[HttpGet]
        //[Route("Comments")]
        //public async Task<ActionResult<IEnumerable<Resume>>> GetComments()
        //{
        //    var commentList = await _context.Comments.ToListAsync();

        //    if (commentList == null || commentList.Count == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(commentList);
        //}

        //[HttpPost]
        //[Route("comments")]
        //public async Task<ActionResult<Resume>> PostComment([Bind("name")] Comments comment)
        //{
        //    if (_context.Comments == null)
        //    {
        //        return Problem("Entity set 'ResumeAPIContext.Comments'  is null.");
        //    }
        //    _context.Comments.Add(comment);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetComments", new { id = comment.CommentId }, comment);
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Resume>>> GetExperiences()
        //{
        //    if (_context.Resume == null)
        //    {
        //        return NotFound();
        //    }
        //    return await _context.Resume.Include(x => x.Educations)
        //                                .Include(x => x.Certifications)
        //                                .Include(x => x.Projects)
        //                                .Include(x => x.Contacts)
        //                                .Include(x => x.Comments)
        //                                .ToListAsync();
        //}

        //// GET: api/Resume/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Resume>> GetResume(Guid id)
        //{
        //  if (_context.Resume == null)
        //  {
        //      return NotFound();
        //  }
        //    var resume = await _context.Resume.FindAsync(id);

        //    if (resume == null)
        //    {
        //        return NotFound();
        //    }

        //    return resume;
        //}

        //// PUT: api/Resume/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutResume(Guid id, Resume resume)
        //{
        //    if (id != resume.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(resume).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ResumeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Resume
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Resume>> PostResume(Resume resume)
        //{
        //  if (_context.Resume == null)
        //  {
        //      return Problem("Entity set 'ResumeAPIContext.Resume'  is null.");
        //  }
        //    _context.Resume.Add(resume);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetResume", new { id = resume.Id }, resume);
        //}

        //// DELETE: api/Resume/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteResume(Guid id)
        //{
        //    if (_context.Resume == null)
        //    {
        //        return NotFound();
        //    }
        //    var resume = await _context.Resume.FindAsync(id);
        //    if (resume == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Resume.Remove(resume);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ResumeExists(Guid id)
        //{
        //    return (_context.Resume?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
