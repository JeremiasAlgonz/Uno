using Uno.Entities.Enums;

namespace Uno.Entities
{
    class Card
    {

        public CardColor Color { get; private set; }
        public int Value { get; private set; }

        public Card()
        {

        }

        public Card(CardColor color)
        {
            Color = color;
        }

        public Card(CardColor color, int value)
        {
            Color = color;
            Value = value;
        }

        
    }
}
