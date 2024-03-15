using BowlingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public IEnumerable<JoinedBowler> GetInfo()
        {
            var bowlerData = _bowlerRepository.GetInfo().ToList();
            return bowlerData;
        }
    }
}