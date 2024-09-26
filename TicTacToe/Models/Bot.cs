using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TicTacToe.Models
{
    internal class Bot : Player
    {
        public BotDifficultyLevel BotDifficultyLevel { get; set; }

        public Bot(char symbol, string name, BotDifficultyLevel botDifficultyLevel) : base(symbol, name,PlayerType.BOT) {
        
            this.BotDifficultyLevel = botDifficultyLevel;
        }
    }
}
