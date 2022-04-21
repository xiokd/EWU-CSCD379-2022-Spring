using Microsoft.AspNetCore.Mvc;
using Wordle.api.Services;

namespace Wordle.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaderBoardController
    {
        [HttpGet]
        public IEnumerable<Score> Get()
        {
            List<Score> results = new ()
            {
                new Score("Hildagaurd", 25, 2.6),
                new Score("Ralph", 30, 3.4),
                new Score("Gene", 50, 4.1),
            };
            return results;
        }

        

    }
}
