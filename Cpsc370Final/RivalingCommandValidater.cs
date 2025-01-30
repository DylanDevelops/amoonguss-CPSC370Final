namespace Cpsc370Final;

public class RivalingCommandValidater
{
    public  static Command Validate(Command command) //needs to be edited for rivaling
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
            else if (Vocabulary.IsNoun(command.Noun) && (command.Noun == "support" || command.Noun == "dps" || command.Noun == "tank"))
            {
                Debugger.Write("Valid class");
                command.IsValid = true;
                
            }
            else
            {
                IO.WriteLine("I don't know the noun/class " + command.Noun + ".");
            }
        }
        else
        {
            IO.WriteLine("I don't know the verb " + command.Verb + ".");
        }
        return command;
    }
}