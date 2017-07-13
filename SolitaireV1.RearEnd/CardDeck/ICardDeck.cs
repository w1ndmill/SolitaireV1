using SolitaireV1.RearEnd.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolitaireV1.RearEnd.CardDeck
{
    public interface ICardDeck
    {

        byte DeckCount { get; set; }
        IEnumerable<IPlayerCard> CardSet { get; }

        void Generate();

    }
}
