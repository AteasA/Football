using System;
using System.Collections.Generic;

namespace Football
{
    public class Game
    {
        private const int NumberOfAssistantReferees = 2;

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee[] AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee, Referee[] assistantReferees)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;

            if (assistantReferees.Length != NumberOfAssistantReferees)
            {
                throw new ArgumentException($"The number of assistant referees should be {NumberOfAssistantReferees}.");
            }

            AssistantReferees = assistantReferees;
            Goals = new List<Goal>();
            Result = "";
            Winner = null;
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            if (Team1.Players.Contains(player) || Team2.Players.Contains(player))
            {
                Goals.Add(new Goal(minute, player));
            }
            else
            {
                throw new ArgumentException("The player does not belong to any of the teams.");
            }
        }

        public void PrintGoals()
        {
            Console.WriteLine("Goals:");

            foreach (Goal goal in Goals)
            {
                Console.WriteLine($"Minute: {goal.Minute}, Player: {goal.Player.Name}");
            }
        }

        public void PrintResult()
        {
            Console.WriteLine("Game Result: " + Result);
            Console.WriteLine("Winner: " + (Winner != null ? Winner.Coach.Name : "None"));
        }
    }
}
