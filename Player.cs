using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    abstract class Player
    {
        string name;
        Roshambo roshambo;

        protected Player(string name)
        {
            this.name = name;
        }

        //protected static Random random = new Random();

        public string Name { get => name; set => name = value; }
        internal Roshambo Roshambo { get => roshambo; set => roshambo = value; }

        public abstract Roshambo GenerateRoShambo();
        
        
    }
}
