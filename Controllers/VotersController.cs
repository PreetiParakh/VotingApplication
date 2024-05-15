using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingApplication.Models;

namespace VotingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotersController : ControllerBase
    {
        private readonly DataContext _context;

        public VotersController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the list of voters
        /// </summary>
        /// <returns>List of Voters</returns>
        // GET: api/Voters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voter>>> GetVoter()
        {
            return await _context.Voters.ToListAsync();
        }

        /// <summary>
        /// Add a voter to the list
        /// </summary>
        /// <param name="voterName"></param>
        /// <returns>Added Voter</returns>
        // POST: api/Voters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Voter>> PostVoter(string voterName)
        {
            var voter = new Voter() { Name = voterName };

            _context.Voters.Add(voter);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostVoter), new { id = voter.Id }, voter);
        }
    }
}