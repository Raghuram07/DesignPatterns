using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Player
    {
        // Auto-implemented properties
        public char Symbol { get; set; }
        public string Name { get; set; }
        public PlayerType Type { get; set; }

        public Player(char symbol, string name, PlayerType type)
        {
            this.Symbol = symbol;
            this.Name = name;
            this.Type = type;
        }
    }
}
