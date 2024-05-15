using Microsoft.AspNetCore.Mvc;
using VotingApplication.Models;

namespace VotingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteCandidatesController : ControllerBase
    {
        private readonly DataContext _context;

        public VoteCandidatesController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// I am {voterId} I vote for {candidateId}
        /// </summary>
        /// <param name="voterId"></param>
        /// <param name="candidateId"></param>
        /// <returns>Success</returns>
        [HttpPost("vote/{voterId}/{candidateId}")]
        public async Task<IActionResult> Vote(int voterId, int candidateId)
        {
            var voter = await _context.Voters.FindAsync(voterId);
            var candidate = await _context.Candidates.FindAsync(candidateId);

            if (voter == null || candidate == null)
                return NotFound();

            if (voter.HasVoted)
                return BadRequest("Voter has already voted.");

            candidate.Votes++;
            voter.HasVoted = true;

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}