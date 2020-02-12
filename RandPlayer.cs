using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    class RandPlayer : Player
    { 
    
        public RandPlayer(string name) : base(name)
        {

        }
        public override Roshambo GenerateRoShambo()
        {
            Random random = new Random();
            int rps = random.Next(0,3);
            this.Roshambo = (Roshambo)rps;
            return (Roshambo)rps;
        }
    }
}
