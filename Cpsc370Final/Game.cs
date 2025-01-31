namespace Cpsc370Final;

public static class Game
{
    public static bool isPlaying { get; private set; }
    
    public static void Play()
    {

        if (!isPlaying)
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
            if (States.GetCurrentState() == StateType.Clicking)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 11);
                if (randomNumber == 10)
                {
                    RandomEvent.GetRandomEvent();
                }
            }
        }
    }

    public static void Quit()
    {
        isPlaying = false;
    }
    

    private static void Initialize()
    {
        isPlaying = true;
        Player.Initialize();
        SandieBank.initialize();
        States.Initialize();
        Inventory.Initialize();
        IO.WriteLine("type help for info on how to play the game.");
    }
    
}