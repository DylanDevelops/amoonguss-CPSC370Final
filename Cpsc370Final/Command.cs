namespace Cpsc370Final;

public class Command
{
    public string Noun = string.Empty;
    public string Verb = string.Empty;
    public bool IsValid = false;

    public string toString()
    {
        return("Command: Verb = [" + Verb + "], Noun = [" + Noun + "], IsValid = [" + IsValid + "]");
    }
    
    public bool HasNoNoun()
    {
        if (Noun == String.Empty)
        {
            return true;
        }
        return false;
    }
}