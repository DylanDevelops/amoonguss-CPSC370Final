namespace Cpsc370Final;

public class ClickingCommandValidater
{
    public  static Command Validate(Command command)
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
                IO.WriteLine("I don't know the noun " + command.Noun + ".");
            }
        }
        else
        {
            IO.WriteLine("I don't know the verb " + command.Verb + ".");
        }
        return command;
    }
}