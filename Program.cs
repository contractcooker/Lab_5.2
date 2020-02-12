using System;
using System.Collections.Generic;

namespace Lab_5._2
{
    class Program
    {       
        static void Main(string[] args)
        {
            Player p2;
            List<Player> playerList = new List<Player>();
            Roshambo roshambo;
            Console.WriteLine("Welcome to RPS!");
            Console.Write("Enter your name: ");
            HumanPlayer p1 = new HumanPlayer(Console.ReadLine());
            playerList.Add(p1);
            Console.Write("Would you like to play against Dwayne Johnson or DeepBlue? (dj/db) ");
            string input = Console.ReadLine();
            if (input.Equals("dj"))
            {
                p2 = new RockPlayer("Dwayne \"The Rock\" Johnson");
                playerList.Add(p2);
            }
            else
            {
                p2 = new RandPlayer("DeepBlue");
                playerList.Add(p2);
            }
            while (true)
            {
                foreach (Player p in playerList)
                {
                    roshambo = p.GenerateRoShambo();
                    
                    Console.WriteLine($"{p.Name} {roshambo}");
                }
                CalculateVictory(p1, p2);

            }


        }

        private static void CalculateVictory(Player p1, Player p2)
        {
            if ((int)p1.Roshambo == 0 && (int)p2.Roshambo == 0)
            {
                Console.WriteLine("Draw");
            }
            if ((int)p1.Roshambo == 0 && (int)p2.Roshambo == 1)
            {
                Console.WriteLine("Lose");
            }
            if ((int)p1.Roshambo == 0 && (int)p2.Roshambo == 2)
            {
                Console.WriteLine("Win");
            }
            if ((int)p1.Roshambo == 1 && (int)p2.Roshambo == 0)
            {
                Console.WriteLine("Win");
            }
            if ((int)p1.Roshambo == 1 && (int)p2.Roshambo == 1)
            {
                Console.WriteLine("Draw");
            }
            if ((int)p1.Roshambo == 1 && (int)p2.Roshambo == 2)
            {
                Console.WriteLine("Lose");
            }
            if ((int)p1.Roshambo == 2 && (int)p2.Roshambo == 0)
            {
                Console.WriteLine("Lose");
            }
            if ((int)p1.Roshambo == 2 && (int)p2.Roshambo == 1)
            {
                Console.WriteLine("Win");
            }
            if ((int)p1.Roshambo == 2 && (int)p2.Roshambo == 2)
            {
                Console.WriteLine("Draw");
            }


        }
    }
}
