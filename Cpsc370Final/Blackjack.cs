namespace Cpsc370Final;

public static class Blackjack
{
        private static Deck deck;
        private static LinkedList<Card> playerHand;
        private static LinkedList<Card> dealerHand;

        private static void Reset()
        {
                playerHand = new LinkedList<Card>();
                dealerHand = new LinkedList<Card>();
                deck = new Deck();
        }
        public static void StartGame()
        {
                Reset();
                
                playerHand.Append(deck.Deal());
                IO.WriteLine(playerHand.ToString());
                dealerHand.Append(deck.Deal());
                IO.WriteLine(dealerHand.ToString());
                playerHand.Append(deck.Deal());
                IO.WriteLine(playerHand.ToString());
                IO.WriteLine("your current hand is " + TotalValue(playerHand));
                if (TotalValue(playerHand) > 21)
                {
                        IO.WriteLine("You Lose!");
                        Casino.Lose();
                }
                else
                {
                        IO.WriteLine("would you like to hit or stay");
                }
        }

        public static void hit()
        {
                playerHand.Append(deck.Deal());
                IO.WriteLine(playerHand.ToString());
                IO.WriteLine("your current hand is " + TotalValue(playerHand));
                if (TotalValue(playerHand) > 21)
                {
                        IO.WriteLine("You Lose!");
                        Casino.Lose();
                }
                else
                {
                        IO.WriteLine("would you like to hit or stay");
                }    
        }

        public static void stay()
        {
                dealerHand.Append(deck.Deal());
                IO.WriteLine(dealerHand.ToString());
                IO.WriteLine("dealer's current hand is " + TotalValue(dealerHand));
                if (TotalValue(dealerHand) > 21)
                {
                        IO.WriteLine("You Win!");
                        Casino.Win();
                }
                else if (TotalValue(dealerHand) > TotalValue(playerHand))
                {
                        IO.WriteLine("You Lose!");
                        Casino.Lose();
                }
                else
                {
                        IO.WriteLine("You Win!");
                        Casino.Win();
                } 
        }
        
        private static int TotalValue(LinkedList<Card> cards)
        {
                int total = 0;
                foreach (Card card in cards)
                {
                        total += card.getValue();
                }
                return total;
        }
}