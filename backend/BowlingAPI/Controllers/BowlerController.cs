using BowlingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlerRepository;

        public BowlerController(IBowlingRepository temp) {
            _bowlerRepository = temp;
        }

        public IEnumerable<Bowler> GetBowlers()
        {
            var bowlerData = _bowlerRepository.Bowlers.ToArray();

            return bowlerData;
        }
    }
}
