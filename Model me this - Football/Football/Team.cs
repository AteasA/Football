using System;
using System.Collections.Generic;

namespace Football
{
    public class Team
    {
        private const int MinimumPlayers = 11;
        private const int MaximumPlayers = 22;

        private List<FootballPlayer> players = new List<FootballPlayer>();

        public Coach Coach { get; set; }

        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count >= MinimumPlayers && value.Count <= MaximumPlayers)
                {
                    players = value;
                }
                else
                {
                    throw new ArgumentException($"The number of players should be between {MinimumPlayers} and {MaximumPlayers}.");
                }
            }
        }

        public double AverageAge
        {
            get
            {
                if (Players.Count == 0)
                {
                    return 0;
                }

                int totalAge = 0;
                foreach (FootballPlayer player in Players)
                {
                    totalAge += player.Age;
                }

                return (double)totalAge / Players.Count;
            }
        }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }
    }
}
