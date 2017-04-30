//Created by Scott Alzheimer
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestsPlayingCard
{
    [TestClass]
    public class Deck_Tests
    {
        [TestMethod]
        public void Can_Create_Deck()
        {

            var deck = Services.Deck.GetDeck();

            Assert.IsTrue(deck.Cards.Count == 52, "Wrong number of cards in deck");
            

        }
        [TestMethod]
        public void Can_Create_Deck_With_4_Suits()
        {

            var deck = Services.Deck.GetDeck();

            Assert.IsTrue(deck.Cards.Count == 52, "Wrong number of cards in deck");

            var currentSuite = Core.Suit.Spades;
            var suitList = new List<Core.Suit>();
            foreach (var card in deck.Cards)
            { 
               if(currentSuite != card.Suit)
               {
                   suitList.Add(currentSuite);
                   currentSuite = card.Suit;
               }

            }

            Assert.IsTrue(suitList.Count == 4, "Deck as wrong number of suits");

        }
      
        [TestMethod]
        public void Can_Sort_Deck()
        {
            var deck = Services.Deck.GetDeck();
            var deck2 = Services.Deck.GetDeck();

            deck.Sort();

            Assert.AreNotSame(deck, deck2, "Deck sort failed: order is same as defualt");
            
            
           var ascendingOrder =new List<Core.Card>();
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ace,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ace,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ace,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ace,Core.Suit.Spades));
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Two,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Two,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Two,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Two,Core.Suit.Spades));
            
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Three,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Three,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Three,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Three,Core.Suit.Spades));
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Four,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Four,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Four,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Four,Core.Suit.Spades));
              
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Five,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Five,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Five,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Five,Core.Suit.Spades));
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Six,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Six,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Six,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Six,Core.Suit.Spades)); 
 
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Seven,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Seven,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Seven,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Seven,Core.Suit.Spades));
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Eight,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Eight,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Eight,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Eight,Core.Suit.Spades));  
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Nine,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Nine,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Nine,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Nine,Core.Suit.Spades));
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ten,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ten,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ten,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Ten,Core.Suit.Spades));

              
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Jack,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Jack,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Jack,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Jack,Core.Suit.Spades));
            
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Queen,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Queen,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Queen,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.Queen,Core.Suit.Spades));
              
            ascendingOrder.Add(new Core.Card(Core.CardOrder.King,Core.Suit.Clubs));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.King,Core.Suit.Dimonds));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.King,Core.Suit.Hearts));
            ascendingOrder.Add(new Core.Card(Core.CardOrder.King,Core.Suit.Spades));

            for (int i = 0; i < ascendingOrder.Count; i++)
            {
                Assert.IsTrue(ascendingOrder[i].Order == deck.Cards[i].Order && ascendingOrder[i].Suit == deck.Cards[i].Suit, String.Format("Deck sort does not match ascending order: Card {0} Suit {1} is not in ascending order",deck.Cards[i].Order,deck.Cards[i].Suit));
            }
            


            
        }
        [TestMethod]
        public void Can_Sort_Shuffle()
        {
            var deck = Services.Deck.GetDeck();
            var deck2 = Services.Deck.GetDeck();

            
            deck.Shuffle();

            Assert.AreNotSame(deck2, deck, "Deck suffle failed: order is same as default");

        }
    }
}
