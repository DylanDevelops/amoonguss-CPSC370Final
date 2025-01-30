namespace Cpsc370Final;

public class Dealer
{
    private Deck deck;

    // Default constructor
    public Dealer()
    {
        deck = new Deck();
    }
    
    //deals entire deck to n players
    //modify this method to deal for other games
    public LinkedList<Card> Deals(int n)
    {
        LinkedList<Card> dealtCards = new LinkedList<Card>();
        dealtCards.Clear();
        for (int i = 0; i < n; i++)
        {
            dealtCards.AddLast(deck.Deal());
        }
        return dealtCards;
    }

    public int Size()
    {
        return deck.Size();
    }

    public override string ToString()
    {
        return deck.ToString();
    }
}