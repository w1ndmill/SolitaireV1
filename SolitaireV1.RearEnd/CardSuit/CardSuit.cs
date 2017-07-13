using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolitaireV1.RearEnd.CardInfo;

namespace SolitaireV1.RearEnd.CardSuit
{
    internal class CardSuit : ICardSuit
    {
        public CardSuitNames Name { get; set; }
        public CardColors Color { get; set; }
        public byte Value { get; set; }
        public byte CardCount { get; set; }


        internal static IEnumerable<ICardSuit> GetAll()
        {

            yield return new CardSuit()
            {
                Name = CardSuitNames.Heart,
                Value = 0,
                CardCount = 13,
                Color = CardColors.Red
            };

            yield return new CardSuit()
            {
                Name = CardSuitNames.Diamond,
                Value = 0,
                CardCount = 13,
                Color = CardColors.Red
            };

            yield return new CardSuit()
            {
                Name = CardSuitNames.Spade,
                Value = 0,
                CardCount = 13,
                Color = CardColors.Black
            };

            yield return new CardSuit()
            {
                Name = CardSuitNames.Club,
                Value = 0,
                CardCount = 13,
                Color = CardColors.Black
            };

        }

    }
}
