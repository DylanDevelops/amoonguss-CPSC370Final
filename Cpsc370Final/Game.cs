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
    }
}