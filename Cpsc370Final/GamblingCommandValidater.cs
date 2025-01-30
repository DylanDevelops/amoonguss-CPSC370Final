namespace Cpsc370Final;

public class GamblingCommandValidater
{
    public  static Command Validate(Command command) //needs to be edited for gambling
    {
        if (Vocabulary.IsVerb(command.Verb))
        {
            Debugger.Write("Valid verb");
            if (Vocabulary.IsStandaloneVerb(command.Verb))
            {
                Debugger.Write("Standalone verb");
                if(command.HasNoNoun())
                {
                    Debugger.Write("No noun");
                    command.IsValid = true;
                }
                else
                {
                    IO.WriteLine("I don't know how to do that.");
                }
                
            }
            else if (Vocabulary.IsNoun(command.Noun))
            {
                Debugger.Write("Valid noun");
                command.IsValid = true;
                
            }
            else
            {
                if (int.Parse(command.Noun) >= 10 && int.Parse(command.Noun) <= 1000 && int.Parse(command.Noun) <= SandieBank.SandieCount)
                {
                    Debugger.Write("Valid number");
                    command.IsValid = true;
                }
                else
                {
                    IO.WriteLine("Invalid noun or bet/raise values amount. All bet/raise values must be at least 10 and at most 1000");
                }
                
            }
        }
        else
        {
            IO.WriteLine("I don't know the verb " + command.Verb + ".");
        }
        return command;
    }
}