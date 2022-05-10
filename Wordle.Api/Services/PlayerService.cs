using Wordle.Api.Data;

namespace Wordle.Api.Services
{
	public class PlayerService
	{
		public PlayerService(AppDbContext context)
		{
			_context = context;

		}

		private AppDbContext _context;

		public IEnumerable<Player> GetPlayer()
		{

		}
	}
}

