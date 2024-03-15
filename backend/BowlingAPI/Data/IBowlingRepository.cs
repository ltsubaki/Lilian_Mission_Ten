namespace BowlingAPI.Data
{
    public interface IBowlingRepository // this it the rules for the template. dictates structure of our class.
    {
        IQueryable<Bowler> Bowlers { get; } // IEnumerable is just a list rather than IQueryable
        IQueryable<Team> Teams { get; }
        IEnumerable<JoinedBowler> GetInfo();
    }
}
