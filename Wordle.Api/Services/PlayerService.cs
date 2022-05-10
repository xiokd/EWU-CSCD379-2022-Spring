using Wordle.Api.Data;

namespace Wordle.Api.Services
{
	
	
	public class PlayerService
	{
	private AppDbContext _context;
		public PlayerService(AppDbContext context)
		{
			_context = context;
		}

		private AppDbContext _context;

		public IEnumerable<Player> GetPlayer(string name)
		{
			//var result = _context.Players.OrderBy(i => i.AverageAttempts).Take(10); // not finished 
			var result = _context.Players.OrderBy(i => i.Name == name); // not finished 
			return result;
		}
		public void  Update(string name, int attempts, int seconds){
			
			 var player = _context.Player
		}
	}
}

