namespace Cpsc370Final;

public static class Blackjack
{
        public static bool inBlackjack = false;
        private static Deck deck = new Deck();
        private static List<Card> playerHand = new List<Card>();
        private static List<Card> dealerHand = new List<Card>();
        
        private static void Reset()
        {
                inBlackjack = true;
                playerHand = new List<Card>();
                dealerHand = new List<Card>();
                deck = new Deck();
        }
        public static void StartGame()
        {
                Reset();
                
                playerHand.Add(deck.Deal());
                IO.WriteLine("Your first card is " + playerHand.Last().ToString());
                dealerHand.Add(deck.Deal());
                IO.WriteLine("Dealer's first card is " + dealerHand.Last().ToString());
                playerHand.Add(deck.Deal());
                IO.WriteLine("Your second card is " + playerHand.Last().ToString());
                IO.WriteLine("your current hand is " + TotalValue(playerHand));
                if (TotalValue(playerHand) > 21)
                {
                        IO.WriteLine("You Lose!");
                        Casino.Lose();
                }
                else
                {
                        IO.WriteLine("would you like to hit or stay");
                        string input = IO.Read();
                        while(input.ToLower() != "hit" || input.ToLower() != "stay")
                        if (input.ToLower() == "hit")
                        {
                                hit();
                        }
                        else if (input.ToLower() == "stay")
                        {
                                stay();
                        }
                }
        }

        public static void hit()
        {
                if (inBlackjack)
                {
                        playerHand.Add(deck.Deal());
                        IO.WriteLine("Your next card is " + playerHand.Last().ToString());
                        IO.WriteLine("your current hand is " + TotalValue(playerHand));
                        if (TotalValue(playerHand) > 21)
                        {
                                IO.WriteLine("You Lose!");
                                Casino.Lose();
                        }
                        else
                        {
                                IO.WriteLine("would you like to hit or stay");
                                string input = IO.Read();
                                while(input.ToLower() != "hit" || input.ToLower() != "stay")
                                        if (input.ToLower() == "hit")
                                        {
                                                hit();
                                        }
                                        else if (input.ToLower() == "stay")
                                        {
                                                stay();
                                        }
                        } 
                }
        }

        public static void stay()
        {
                if (inBlackjack)
                {
                        dealerHand.Add(deck.Deal());
                        IO.WriteLine("Dealer's second card is " + dealerHand.Last().ToString());
                        IO.WriteLine("Dealer's current hand is " + TotalValue(dealerHand));
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
        }
        
        private static int TotalValue(List<Card> cards)
        {
                int total = 0;
                foreach (Card card in cards)
                {
                        total += card.getValue();
                }
                return total;
        }
}