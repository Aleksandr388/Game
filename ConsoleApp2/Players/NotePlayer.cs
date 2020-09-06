using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class NotePlayer : IPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public NotePlayer(string name, string type)
        {
            Name = name;
            Type = type;
        }
        
        public int Play(HashSet<int> answers)
        {
            Random rand = new Random();

            HashSet<int> Otvet = new HashSet<int>();

            int result;
          
            do
            {
                result = rand.Next(40, 140); ;
            } 
            while (Otvet.Contains(result));

            Otvet.Add(result);

            return result;
        }
    }
}