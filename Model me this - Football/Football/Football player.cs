using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public FootballPlayer(string name, int age, int number, double height)
        {
            Name = name;
            Age = age;
            Number = number;
            Height = height;
        }
    }
}
