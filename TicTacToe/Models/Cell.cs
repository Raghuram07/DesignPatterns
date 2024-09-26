using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
        public class Cell
        {
            // Auto-implemented properties for the cell's attributes
            public Player Player { get; set; }
            public int Row { get; set; }
            public int Col { get; set; }
            public CellState CellState { get; set; }

            public Cell(int row , int col)
            {
                Row = row;
                Col = col;
                CellState = CellState.EMPTY;
            }

        }
}
