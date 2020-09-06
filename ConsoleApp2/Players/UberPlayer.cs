using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class UberPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Result { get; set; }

        

        public UberPlayer(string name, string type)
        {
            Name = name;
            Type = type;
            Result = 39;
        }

        public int Play(HashSet<int> answers)
        {           
            return ++Result;
        }
    }
}
