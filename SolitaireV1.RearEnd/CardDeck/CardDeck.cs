using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolitaireV1.RearEnd.Card;
using SolitaireV1.RearEnd.CardSuit;
using SolitaireV1.RearEnd.CardInfo;

namespace SolitaireV1.RearEnd.CardDeck
{
    public class CardDeck : ICardDeck
    {
        public byte DeckCount { get; set; }

        public IEnumerable<IPlayerCard> CardSet { get; private set; }


        public void Generate()
        {
            var suitSet = CardSuit.CardSuit.GetAll().ToList();
            var cardSetHelper = new List<IPlayerCard>();

            for (int h = 0; h < DeckCount; h++)
            {
                for (int i = 0; i < suitSet.Count(); i++)
                {
                    for (int j = 0; j < suitSet[i].CardCount; j++)
                    {
                        var card = new PlayerCard()
                        {
                            Suit = suitSet[i],
                            CardScent = (decimal)1.00,
                            IsMoveable = true,
                            Orientiation = CardOrientations.FaceDown,
                            Value = (byte)(j + 1)
                        };


                        cardSetHelper.Add(card);
                    }
                }
            }

            CardSet = cardSetHelper;
        }

    }
}
