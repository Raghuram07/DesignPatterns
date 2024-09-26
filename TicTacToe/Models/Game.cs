using System;
using System.Collections.Generic;

namespace TicTacToe.Models
{
    public class Game
    {
        // Auto-implemented properties
        public Board Board { get; set; }
        public List<Player> Players { get; set; }
        public List<Move> Moves { get; set; }
        public GameStatus GameStatus { get; set; }
        public int NextPlayerIndex { get; set; }

        // Private constructor to enforce use of builder pattern
        private Game() { }

        // Builder class to construct the Game object
        public class Builder
        {
            private int Dimension;
            private List<Player> Players = new List<Player>();

            // Setter for Dimension
            public Builder SetDimension(int dimension)
            {
                this.Dimension = dimension;
                return this;
            }

            // Setter for Players
            public Builder SetPlayers(List<Player> players)
            {
                this.Players = players ?? throw new ArgumentNullException(nameof(players));
                return this;
            }

            // Validation method to ensure correct configuration
            private bool IsValid()
            {
                // Ensure the number of players is appropriate
                if (Players.Count != Dimension - 1)
                {
                    throw new InvalidOperationException("The number of players must be one less than the board dimension.");
                }
                if (Players.Count == 0)
                {
                    throw new InvalidOperationException("There must be at least one player to start the game.");
                }
                return true;
            }

            // Build method to create the Game object
            public Game Build()
            {
                // Validate before creating the game
                if (!this.IsValid())
                {
                    Console.WriteLine("Validations not passed, couldn't start the game.");
                    return null;
                }

                var game = new Game
                {
                    GameStatus = GameStatus.IN_PROGRESS,
                    Players = Players,
                    Board = new Board(this.Dimension), // Assuming Board has a constructor accepting dimension
                    Moves = new List<Move>(),
                    NextPlayerIndex = 0
                };

                return game;
            }
        }
    }
}
