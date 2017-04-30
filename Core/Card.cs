using System;
using Core;

namespace Core
{
    public class Card:IComparable<Card>
    {

        public CardOrder Order { get; private set; }
        public Suit Suit { get; private set; }

        public Card(CardOrder order, Suit suit)
        {
            Order = order;
            Suit = suit;
        }

        public int CompareTo(Card other)
        {
            //Sort by card value first
            if (Order != other.Order)
                return Order.CompareTo(other.Order);

            // compare suits when order value is the same
            return Suit.CompareTo(other.Suit);
        }
    }
}
