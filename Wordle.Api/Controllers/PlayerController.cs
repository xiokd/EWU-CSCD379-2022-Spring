using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wordle.Api.Data;
using Wordle.Api.Services;

namespace Wordle.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{
    private readonly PlayerService _service;
    public PlayerController(PlayerService service)
	{
		_service = service;
	}

    [HttpGet]
    public IEnumerable<Player> Get()
    {
        return _service.GetPlayer();
    }

    [HttpPost]
    public IActionResult Post([FromBody] PlayerPost player)
    {
        // check if score 
        _service.Update(player);
        return Ok();
    }
    public class PlayerPost
    {
        public String PlayerId {get; set;}
        public String Name {get; set;}
        public int GameCount {get; set;}
        public double AverageAttempts {get; set;}
    }
}

