namespace Cpsc370Final;

public class Vocabulary
{
    public static List<string> notStandaloneVerbs = new List<string>()
        {"buy", "bet", "play", "show", "see"};
    public static List<string> standaloneVerbs = new List<string>()
        {"click", "quit", "casino", "rivals", "hit", "stay", "exit", "shop", "c", "clicked", "tsivkovski", "help"};
    public static List<string> nouns = new List<string>()
        {"casino", "rivals", "slots", "blackjack", "jon", "slingshot", "cloner", "farm", "typeless", "costume", "prices", "support", "dps", "tank"};

    public static bool IsVerb(string word)
    {
        return notStandaloneVerbs.Contains(word) || standaloneVerbs.Contains(word);
    }

    public static bool IsStandaloneVerb(string word)
    {
        return standaloneVerbs.Contains(word);
    }

    public static bool IsNoun(string word)
    {
        return nouns.Contains(word);
    }

    public static void AddNoun(string name)
    {
        name = name.ToLower();
        if(!nouns.Contains(name))
            nouns.Add(name);
    }
}