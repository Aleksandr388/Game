using System.Collections.Generic;

namespace ConsoleApp2
{
    public interface IGame
    {
        void CreateGame();

        string[] GetTypesOfPlayer();

        IPlayer CreatePlayer(string name, string type);

        void StartGame(IEnumerable<IPlayer> players, int basketWeight);

        void CheckCountPlayers(int countPlayer);
    }
}