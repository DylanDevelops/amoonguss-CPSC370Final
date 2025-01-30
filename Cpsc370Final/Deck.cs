namespace Cpsc370Final;

public class Deck
{
    private LinkedList<Card> cards = new LinkedList<Card>();

    // Default constructor
    public Deck()
    {
        for (int s = 0; s < 4; s++)
        {
            for (int r = 2; r < 15; r++)
            {
                cards.AddLast(new Card(s, r));
            }
        }
    }

    // Copy constructor
    public Deck(Deck deckToCopy)
    {
        foreach (var card in deckToCopy.cards)
        {
            cards.AddLast(card);
        }
    }

    // Secondary copy constructor
    public Deck(LinkedList<Card> deckToCopy)
    {
        foreach (var card in deckToCopy)
        {
            cards.AddLast(card);
        }
    }

    public override string ToString()
    {
        string sb = "";
        foreach (Card card in cards)
        {
            sb += card.ToString() + " ";
        }

        return sb;
    }

    public int Size()
    {
        return cards.Count;
    }

    public Card Deal()
    {
        Random random = new Random();
        int d = random.Next(cards.Count);
        var node = cards.First;
        for (int i = 0; i < d; i++)
        {
            node = node.Next;
        }
        Card l = node.Value;
        cards.Remove(node);
        return l;
    }

    public Card DrawTop()
    {
        Card l = cards.Last.Value;
        cards.RemoveLast();
        return l;
    }
    
}