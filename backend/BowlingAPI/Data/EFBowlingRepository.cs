
namespace BowlingAPI.Data
{
    public class EFBowlingRepository: IBowlingRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }
        public IQueryable<Bowler> Bowlers => _context.Bowlers;
        public IQueryable<Team> Teams => _context.Teams;

        public IEnumerable<JoinedBowler> GetInfo()
        {
            var query = (from bowler in _context.Bowlers
                         join team in _context.Teams
                         on bowler.TeamId equals team.TeamId
                         where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                         select new JoinedBowler()
                         {
                             BowlerId = bowler.BowlerId,
                             BowlerFirstName = bowler.BowlerFirstName,
                             BowlerMiddleInit = bowler.BowlerMiddleInit,
                             BowlerLastName = bowler.BowlerLastName,
                             TeamId = team.TeamId,
                             TeamName = team.TeamName,
                             BowlerAddress = bowler.BowlerAddress,
                             BowlerCity = bowler.BowlerCity,
                             BowlerState = bowler.BowlerState,
                             BowlerZip = bowler.BowlerZip,
                             BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                         }).ToList();
            return query;

        }
    }
}
