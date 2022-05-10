namespace Wordle.Api.Services;
using System.ComponentModel.DataAnnotations;

// makes a table of players

public class Player
{
        [Key]
        public int PlayerId { get; set; }
        public string? Name { get; set; }
        public int GameCount { get; set; }
        public double AverageAttempts { get; set; }
        public int AverageTime { get; set; }

        // public Player Clone()
        // {
        //     return new Player
        //     {
        //         PlayerId = PlayerId,
        //         Name = Name,
        //         GameCount = GameCount,
        //         AverageAttempts = AverageAttempts,
        //         AverageTime = AverageTime

        //     };
        // }
}


