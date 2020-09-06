using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class CheaterPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public CheaterPlayer(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public int Play(HashSet<int> answers)
        {
            Random rand = new Random();

            int result;         
            
            do
            {
                result = rand.Next(40, 140);
            }
            while (answers.Contains(result));

            return result;
        }
    }
}
