using System.Collections.Generic;

namespace ConsoleApp2
{
    public interface IPlayer
    {
        string Name { get; set; }

        string Type { get; set; }

        int Play(HashSet<int> answers);
        
    }
}