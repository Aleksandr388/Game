using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class RegularPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public RegularPlayer(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public int Play(HashSet<int> answers)
        {
            Random rand = new Random();

            int result = rand.Next(40, 45);

            return result;          
        }
    }
}