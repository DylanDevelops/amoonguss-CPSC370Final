namespace Cpsc370Final;

public class CommandProcessor
{
    public static Command GetCommand()
    {
        IO.WriteLine($"\n~ Sandies: $" + SandieBank.SandieCount);
        IO.Write("Input: ");
        
        string input = IO.Read();
        Debugger.Write("Raw Input: [" + input + "]");
        Command command = Parser.Parse(input);
        Debugger.Write("After parsing Verb = [" + command.Verb + "], Noun = [" + command.Noun + "]");
        command = CommandValidater.ValidateCommand(command);

        return command;
    }
}