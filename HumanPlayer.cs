using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {

        }
        public override Roshambo GenerateRoShambo()
        {
            Console.Write("rock, paper, or scissors? ");
            string input = Console.ReadLine();
            if (input.Equals("rock"))
            {
                this.Roshambo = Roshambo.ROCK;
                return Roshambo.ROCK;
            }
            if (input.Equals("paper"))
            {
                this.Roshambo = Roshambo.PAPER;
                return Roshambo.PAPER;
            }
            this.Roshambo = Roshambo.SCISSORS;
            return Roshambo.SCISSORS;
        }
    }
}
