using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wordle.Api.Data;
using Wordle.Api.Services;

namespace Wordle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreStatsController : ControllerBase
    {

        private readonly ScoreStatsService _service;
        public ScoreStatsController(ScoreStatsService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IEnumerable<ScoreStat> Get()
        {
            return _service.GetScoreStats();

        }
    }
}
