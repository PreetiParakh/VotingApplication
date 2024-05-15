using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingApplication.Models;

namespace VotingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly DataContext _context;

        public CandidatesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Candidates
        /// <summary>
        /// Get list of all Candidates
        /// </summary>
        /// <returns>List of all Candidates</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidates()
        {
            return await _context.Candidates.ToListAsync();
        }

        /// <summary>
        /// Add a Candidate to the list
        /// </summary>
        /// <param name="candidateName"></param>
        /// <returns>Added Candidate</returns>
        // POST: api/Candidates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidate(string candidateName)
        {
            var candidate = new Candidate() { Name = candidateName };

            _context.Candidates.Add(candidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostCandidate), new { id = candidate.Id }, candidate);
        }
    }
}