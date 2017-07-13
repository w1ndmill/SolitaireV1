using SolitaireV1.RearEnd.CardInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolitaireV1.RearEnd.CardSuit
{
    public interface ICardSuit
    {

        CardSuitNames Name { get; set; }
        CardColors Color { get; set; }
        byte Value { get; set; }
        byte CardCount { get; set; }

    }
}