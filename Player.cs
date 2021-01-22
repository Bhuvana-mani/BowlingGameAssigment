using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameLibrary
{
     public class Player
    {
        public string Name { get; }
        public GameScore GameScore { get; set; }
        public Player(string name)
        {
            Name = name;
            GameScore = new GameScore();
        }
    }
}
