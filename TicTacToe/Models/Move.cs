using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Move
    {
        public Player Player { get; set; }
        public Cell Cell { get; set; }

        public Move(Player player, Cell cell)
        {
            Player = player;
            Cell = cell;
        }
    }
}
