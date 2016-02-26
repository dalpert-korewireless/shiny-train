using System;
using System.Collections.Generic;

namespace ShinyTrain.Domain
{
    public class TwixTGame
    {
        public TwixTGame(string name)
        {
            Name = name;
            DateCreated = DateTime.Now;
            Players = new List<Player>();
        }

        public List<Player> Players { get; set; }

        public DateTime DateCreated { get; set; }

        public string Name { get; private set; }
    }
}