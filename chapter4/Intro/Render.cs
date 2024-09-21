using Spectre.Console;
using Spectre.Console.Cli;

public partial class Game
{
    private void RenderMenu()
    {
        Console.Clear();
        AnsiConsole.Markup("[underline red]Hello[/], World");
        Console.WriteLine("Welcome to Rock, Paper, Scissors.");
        Console.WriteLine("Enter your choice:");
        Console.WriteLine("\t\t1) Rock");
        Console.WriteLine("\t\t2) Paper");
        Console.WriteLine("\t\t3) Scissor");
        Console.WriteLine();
    }

    private void AnnounceWinner(string winner)
    {
        Console.WriteLine("Winner: {0}", winner);
        Console.WriteLine("enter y for Next Round");
    }

    private void DisplayStats()
    {
        Console.WriteLine("Total number of rounds : {0}", rounds);
        Console.WriteLine("Player wins : {0}", playerWins);
        Console.WriteLine("Computer wins : {0}", computerWins);
        Console.WriteLine("Draws {0}", rounds - (playerWins + computerWins));
    }
}