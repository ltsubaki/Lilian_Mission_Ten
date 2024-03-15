namespace BowlingAPI.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }
}
