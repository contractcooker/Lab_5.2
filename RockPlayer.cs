using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name)
        {

        }
        public override Roshambo GenerateRoShambo()
        {
            this.Roshambo = Roshambo.ROCK;
            return Roshambo.ROCK;
        }
    }
}
