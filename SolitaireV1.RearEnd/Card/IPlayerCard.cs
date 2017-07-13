using SolitaireV1.RearEnd.CardInfo;
using SolitaireV1.RearEnd.CardSuit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireV1.RearEnd.Card
{
    public interface IPlayerCard
    {

        ICardSuit Suit { get; set; }
        byte Value { get; set; }
        CardOrientations Orientiation { get; set; }
        bool IsMoveable { get; set; }
        decimal CardScent { get; set; }

    }
}
