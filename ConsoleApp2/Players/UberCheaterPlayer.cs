using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class UberCheaterPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Result { get; set; }

        public UberCheaterPlayer(string name, string type)
        {
            Name = name;
            Type = type;
            Result = 39;
        }

        public int Play(HashSet<int> answers)
        {
            int result = 39;

            if (answers.Contains(result))
            {
                result++;
            }
            return result;
        }
    }
}
