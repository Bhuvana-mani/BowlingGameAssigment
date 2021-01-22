using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameLibrary
{
    public class Game
    {
        private int _count=0;
        private bool _firstRoll = true;
        public Game(List<string> names)
        {
            if (names.Count == 0)
            {
                throw new ArgumentNullException();
            }
            else if (names.Count > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {


                foreach (var name in names)
                {
                    var player = new Player(name);
                    Players.Add(player);
                }
            }
        }
        public Player _activePlayer => Players[_count];
        public List<Player> Players { get; set; } = new List<Player>();
        public void Roll(int pins)
        {
            _activePlayer.GameScore.Roll(pins);
            if(pins==10)
            {
                _count++;
            }
            else
            {
                if (_firstRoll == true)
                {
                    _firstRoll = false;
                }
                else
                {
                    _firstRoll = true;
                    _count++;
                }
            }
        }

    }
}
