using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolitaireV1.RearEnd.CardSuit;
using SolitaireV1.RearEnd.CardInfo;

namespace SolitaireV1.RearEnd.Card
{
    internal class PlayerCard : IPlayerCard
    {
        public ICardSuit Suit { get; set; }
        public byte Value { get; set; }
        public CardOrientations Orientiation { get; set; }
        public bool IsMoveable { get; set; }
        public decimal CardScent { get; set; }
    }
}
