using System;
using System.Collections.Generic;
using Core;

namespace Services
{
    public class Deck
    {
        private Random random = new Random();

        /// <summary>
        /// Cards contains 52 cards in 4 suits with 13 cards in each
        /// </summary>
        public List<Card> Cards { get; private set; }

        private Deck()
        {
            Cards = new List<Card>();
        }
        /// <summary>
        /// Get deck of cards
        /// </summary>
        /// <returns></returns>
        public static Deck GetDeck()
        {

            var deck = new Deck();

            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int cardOrderIndex = 0; cardOrderIndex < 13; cardOrderIndex++)
                {

                    deck.Cards.Add(new Card((CardOrder)cardOrderIndex, (Suit)suitIndex));
                }
            }


            return deck;
        }

        public void Sort()
        {
            Cards.Sort();
        }

        public void Shuffle()
        {
            List<Card> cardsToShuffle = new List<Card>(Cards);
            Cards.Clear();

            while (cardsToShuffle.Count > 0)
            {
                var currentCard = random.Next(cardsToShuffle.Count);

                var card = cardsToShuffle[currentCard];

                cardsToShuffle.RemoveAt(currentCard);

                Cards.Add(card);

            
            }
        }
    }
}
