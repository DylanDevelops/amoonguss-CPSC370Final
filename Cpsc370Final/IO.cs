namespace Cpsc370Final;

public class IO
{
    public static void WriteLine(string output)
    {
        Console.WriteLine(output);
    }
    public static void Write(string output)
    {
        Console.Write(output);
    }
    
    public static string Read()
    {
        return Console.ReadLine();
    }

    public static void Error(string output)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        WriteLine("ERROR: " + output);
        Console.ResetColor();
    }
}