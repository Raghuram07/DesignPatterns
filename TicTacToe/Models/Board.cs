using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Board
    {
        public List<List<Cell>> GameBoard { get; set; }

        public Board(int dimensions) {
            // initialize an empty matrix of size dimension * dimension
            
            this.GameBoard = new List<List<Cell>>();

            for (int i = 0; i < dimensions; i++)
            {
                this.GameBoard.Add(new List<Cell>());
                for (int j = 0; j < dimensions; j++)
                {
                    this.GameBoard[i].Add(new Cell(i,j));
                }
            }
        
        }

    }
}
