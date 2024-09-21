public partial class Game
{
    private string? userInput, computerInput;
    private readonly string[] inputs = ["rock", "paper", "scissor"];
    private bool gameLoop = true;

    private int rounds;
    public int playerWins, computerWins;


    public void RunGame()
    {
        while (gameLoop)
        {
            RenderMenu();
            rounds += 1;

            computerInput = System.Random.Shared.GetItems<string>(inputs, 1)[0];
            object input = Console.ReadLine() ?? String.Empty;
            var choice = Int32.TryParse(input.ToString(), out int c) ? inputs[(c - 1) % 3] : input.ToString();
            userInput = choice!.ToLower();

            string winner = (computerInput, userInput) switch
            {
                ("paper", "scissor") => "User",
                ("paper", "rock") => "Computer",
                ("paper", "paper") => "Draw",
                ("scissor", "scissor") => "Draw",
                ("scissor", "rock") => "User",
                ("scissor", "paper") => "Computer",
                ("rock", "scissor") => "Computer",
                ("rock", "rock") => "Draw",
                ("rock", "paper") => "User",
                _ => "wrong input"
            };

            if (winner == "User")
            {
                playerWins += 1;
            }
            else if (winner == "Computer")
            {
                computerWins += 1;
            }
            else
            {
                Console.WriteLine("Wrong Input: {0}", winner);
            }

            AnnounceWinner(winner);
            ConsoleKeyInfo playAgainChoiceInput = Console.ReadKey();
            bool PlayAgain = (playAgainChoiceInput.Key is ConsoleKey.Y) ? true : false; 
            gameLoop = PlayAgain;
        }
        DisplayStats();
    }
}