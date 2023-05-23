using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаване на играчи
            FootballPlayer player1 = new FootballPlayer("Player 1", 10, 25, 180);
            FootballPlayer player2 = new FootballPlayer("Player 2", 7, 28, 175);

            // Създаване на отбори
            Team team1 = new Team(new Coach("Coach 1", 45), new List<FootballPlayer> { player1, player2 });
            Team team2 = new Team(new Coach("Coach 2", 50), new List<FootballPlayer>());

            // Създаване на мач
            Referee referee = new Referee("Referee 1", 40);
            Referee[] assistantReferees = new Referee[] { new Referee("Assistant Referee 1", 35), new Referee("Assistant Referee 2", 38) };
            Game game = new Game(team1, team2, referee, assistantReferees);

            // Изпълнение на логика
            team2.Players.Add(new FootballPlayer("Player 3", 9, 24, 183));
            game.Goals.Add(new Goal(10, player1));
            game.Goals.Add(new Goal(25, team2.Players[0]));
            game.Result = "2-1";
            game.Winner = team1;

            // Принтиране на резултата
            Console.WriteLine("Team1 - Team2");
            Console.WriteLine("Game Result: " + game.Result);

            Console.ReadLine();
        }
    }
}
