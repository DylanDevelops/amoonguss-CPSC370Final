namespace Cpsc370Final;

public class Card
{
    //assigning a value to each suit
    public static int HEARTS = 0;
    public static int SPADES = 1;
    public static int CLUBS = 2;
    public static int DIAMONDS = 3;

    //assigns a value to non number cards
    public static int JACK = 11;
    public static int QUEEN = 12;
    public static int KING = 13;
    public static int ACE = 1;
    
    //suit of card
    private int suit;
    //rank of card
    private int rank; 

    //default cnstructror
    public Card()
    {
        suit = SPADES;
        rank = ACE;
    }
    //overloaded constructor
    public Card(int s, int r)
    {
        suit = s;
        rank = r;
    }
    //copy constructor
    public Card(Card Cardtocopy)
    {
        suit = Cardtocopy.suit;
        rank = Cardtocopy.rank;

    }
    //toString
    public String toString()
    {
        String str = "";
        if(rank < 11)
        {
            str += rank;
        }
        else{
            if(rank == 11)
            {
            str += "Jack";
            }
            else if(rank == 12)
            {
            str += "Queen";
            }
            else if(rank == 13)
            {
            str += "King";
            }
            else if(rank == 14)
            {
            str += "Ace";
            }
        }
        if(suit == 0)
        {
            str += " of Hearts";
        }
        else if(suit == 1)
        {
            str += " of Spades";
        }
        else if(suit == 2)
        {
            str += " of Clubs";
        }
        else if(suit == 3)
        {
            str += " of Diamonds";
        }
        return str;
    }
    //equals method. returns true if the cards ranks are the same
    public bool equals(Object o)
    {
        //checks if theya re the same
        if(this == o)
        {
            return true;
        }
        //checks if tehy are a card
        if(!(o is Card))
        {
            return false;
        }
        //turns into card object to be refrenced
        Card s =  (Card) o;
        //returns wheteher they are equal or not
        return(this.rank == s.rank);
    }
    public void setRank(int rank)
    {
        rank = rank;
    }
    public void setSuit(int suit)
    {
        suit = suit;
    }
    public String getRank()
    {
        String str = "";
        if(rank < 11)
        {
            str += rank;
        }
        else
        {
            if(rank == 11)
            {
            str += "Jack";
            }
            else if(rank == 12)
            {
            str += "Queen";
            }
            else if(rank == 13)
            {
            str += "King";
            }
            else if(rank == 14)
            {
            str += "Ace";
            }
        }
        return str;
    }
    public String getSuit()
    {
        String str = "";
        if(suit == 0)
        {
            str += "Hearts";
        }
        else if(suit == 1)
        {
            str += "Spades";
        }
        else if(suit == 2)
        {
            str += "Clubs";
        }
        else if(suit == 3)
        {
            str += "Diamonds";
        }
        return str;
    }
    public int getValue()
    {
        return rank;
    }
}