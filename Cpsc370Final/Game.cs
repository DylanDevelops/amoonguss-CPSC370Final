namespace detective;

public static class Game
{
    private static bool isPlaying = true;
    private static bool hasPlayed = false;
    public static void Play()
    {
        if (hasPlayed)
        {
            Reset();
        }
        else
        {
            Initialize();
        }
        while (isPlaying)
        {
            Command command = CommandProcessor.GetCommand();
            if (command.IsValid)
            {
                Debugger.Write(command.toString());
                CommandHandler.Handle(command);
            }
        }
        playAgainPrompt();
    }

    private static void Initialize()
    {
        //Debugger.Tron();
        InfoDump.dump();
        Map.Initialize();
        Player.Initialize();
        States.Initialize();
        Conditions.Initialize();
        Items.Initialize();
    }

    private static void Reset()
    {
        InfoDump.dump();
        Map.Reset();
        Player.Reset();
        Conditions.Reset();
        Items.Reset();
    }

    public static void WinGame()
    {
        IO.WriteLine("That's it.");
        IO.WriteLine("That's the game.");
        IO.WriteLine("You won?");
        isPlaying = false;
    }
    
    public static void LoseGame()
    {
        IO.WriteLine("You Died.");
        IO.WriteLine("YOU LOSE!");
        isPlaying = false;
    }

    public static void playAgain()
    {
        hasPlayed = true;
        isPlaying = true;
        States.ChangeState(StateType.Exploring);
        Game.Play();
    }

    private static void playAgainPrompt()
    {
        States.ChangeState(StateType.PlayAgain);
        IO.WriteLine("Would you like to play again?");
        Command command = CommandProcessor.GetCommand();
        if (command.IsValid)
        {
            Debugger.Write(command.toString());
            CommandHandler.Handle(command);
        }
    }
}