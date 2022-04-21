namespace Wordle.api.Services
{
    public interface ILeaderBoardService
    {
        IEnumerable<Score> GetScores();
    }
}
