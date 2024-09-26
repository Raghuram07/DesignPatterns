using TicTacToe.Models;
using System;
using System.Collections.Generic;

try
{
    // Read the number of players and board dimension from the user
    Console.WriteLine("Enter board dimension:");
    int dimension = int.Parse(Console.ReadLine());

    Console.WriteLine($"You need {dimension - 1} players for this game.");

    // Create the list of players
    List<Player> players = new List<Player>();

    for (int i = 0; i < dimension - 1; i++)
    {
        Console.WriteLine($"Enter name for Player {i + 1}:");
        string name = Console.ReadLine();

        Console.WriteLine($"Enter symbol for Player {i + 1} (single character):");
        char symbol = Console.ReadLine()[0];

        Console.WriteLine("Enter type for Player (Human or Bot):");
        string typeInput = Console.ReadLine();

        if (typeInput.Equals("Bot", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Choose Bot Difficulty level");
            string difficultyLevel = Console.ReadLine();
            players.Add(new Bot(symbol, name, BotDifficultyLevel.EASY));
        }
        else
        {
            players.Add(new Player(symbol, name, PlayerType.HUMAN));
        }
    }

    // Build the game using the input from the user
    var game = new Game.Builder()
        .SetDimension(dimension)
        .SetPlayers(players)  // Pass the list of players
        .Build();

    if (game != null)
    {
        Console.WriteLine("Game started successfully.");
    }
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter the correct values.");
}
