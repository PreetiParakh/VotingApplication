namespace VotingApplication.Models
{
    public class Voter
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool HasVoted { get; set; }
    }
}