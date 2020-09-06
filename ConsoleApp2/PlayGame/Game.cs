using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    public class Game : IGame
    {
        private const string type1 = nameof(RegularPlayer);
        private const string type2 = nameof(NotePlayer);
        private const string type3 = nameof(UberPlayer);
        private const string type4 = nameof(CheaterPlayer);
        private const string type5 = nameof(UberCheaterPlayer);

        HashSet<int> Answers = new HashSet<int>();

        public void PrintTypesOfPlayer()
        {
            var types = GetTypesOfPlayer();

            Console.WriteLine("Available type:");
            foreach (var type in types)
            {
                Console.WriteLine(type);
            }
        }

        public string[] GetTypesOfPlayer()
        {
            return new[] { type1, type2, type3, type4, type5 };
        }

        public void CheckCountPlayers(int countPlayer)
        {
            if (countPlayer < 2)
            {
                Console.WriteLine("Min value players 2...");
                Console.Write("Enter countPlayer: ");

                countPlayer = Convert.ToInt32(Console.ReadLine());
            }

            if (countPlayer > 8)
            {
                Console.WriteLine("Max value players 8...");
                Console.Write("Enter countPlayer: ");

                countPlayer = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void CheckBasketWeight(int basketWeight)
        {
            if (basketWeight <= 40 && basketWeight >= 140)
            {
                Console.WriteLine("Error try again..");
                Console.Write("Enter basketWeight:");

                basketWeight = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void CreateGame()
        {
            var players = new List<IPlayer>();

            Console.Write("Enter countPlayer: ");

            int countPlayer = Convert.ToInt32(Console.ReadLine());

            CheckCountPlayers(countPlayer);

            Console.Write("Enter basketWeight: ");

            int basketWeight = Convert.ToInt32(Console.ReadLine());

            CheckBasketWeight(basketWeight);

            for (int i = 0; i < countPlayer; i++)
            {
                Console.WriteLine("Creat player...");
                PrintTypesOfPlayer();
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter type: ");
                string type = Console.ReadLine();

                players.Add(CreatePlayer(name, type));
            }

            StartGame(players, basketWeight);
        }

        public IPlayer CreatePlayer(string name, string type)
        {
            switch (type)
            {
                case type1:
                    return new RegularPlayer(name, type);
                case type2:
                    return new NotePlayer(name, type);
                case type3:
                    return new UberPlayer(name, type);
                case type4:
                    return new CheaterPlayer(name, type);
                case type5:
                    return new UberCheaterPlayer(name, type);

                default: throw new Exception("not exist type of player");
            }
        }

        public void StartGame(IEnumerable<IPlayer> players, int basketWeight)
        {
            bool end = false;

            int count = 0;

            while (!end || count == 100)
            {
                HashSet<int> answers = new HashSet<int>();

                foreach (var player in players)
                {
                    int result = player.Play(answers);

                    answers.Add(result);

                    if (result == basketWeight)
                    {
                        end = true;

                        Console.WriteLine($"Player {player.Name}, {player.Type} win!");
                    }

                    else
                    {
                        Console.WriteLine("Did not guess");
                    }

                    count++;
                }

                if (count > 100)
                {
                    int closest = Answers.Aggregate((x, y) => Math.Abs(x - basketWeight) < Math.Abs(y - basketWeight) ? x : y);
                    Console.WriteLine("End Game");
                    Console.WriteLine($"Closet value {closest}");
                }
            }
        }
    }
}