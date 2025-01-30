namespace Cpsc370Final;

public class Debugger
{
    private static bool isActive = false;
    public static void Write(string message)
    {
        if (isActive)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            IO.WriteLine(message);
            Console.ResetColor();
        }
    }

    public static void Tron()
    {
        isActive = true;
        IO.WriteLine("Debugger Enabled");
    }

    public static void Troff()
    {
        isActive = false;
        IO.WriteLine("Debugger Disabled");
    }
}