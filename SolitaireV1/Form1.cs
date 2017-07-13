using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolitaireV1.RearEnd;
using SolitaireV1.RearEnd.CardDeck;

namespace SolitaireV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GenerateDeck_Click(object sender, EventArgs e)
        {
            txt_CardViewer.Clear();


            var deck = new CardDeck()
            {
                DeckCount = 1
            };


            deck.Generate();


            deck.CardSet.ToList().ForEach(card =>
            {
                string cardInfo = card.Suit.Name + " =>" + card.Value;

                txt_CardViewer.AppendText(cardInfo + Environment.NewLine);

            });


        }

        int xOriginal = 0;
        int yOriginal = 0;
        int xOffset_Inner = 0;
        int yOffset_Inner = 0;
        int xOffset_Outer = 0;
        int yOffset_Outer = 0;

        Control dragItem = null;

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            var clickLbl = (Label)sender;

            clickLbl.BringToFront();

            dragItem = clickLbl;

            var relativePoint = this.PointToClient(Cursor.Position);

            xOriginal = relativePoint.X;
            yOriginal = relativePoint.Y;

            xOffset_Inner = xOriginal - clickLbl.Location.X;

            yOffset_Inner = yOriginal - clickLbl.Location.Y;
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragItem == null)
            {
                return;
            }

            var relativePoint = this.PointToClient(Cursor.Position);

            //left border AND dragging left
            if ((Cursor.Position.X < this.Location.X + 50 && relativePoint.X < xOriginal) ||
                //right border AND dragging right
                (Cursor.Position.X > this.Location.X + this.Width - 50 && relativePoint.X > xOriginal) ||
                //top border and dragging up
                (Cursor.Position.Y < this.Location.Y + 50 && relativePoint.Y < yOriginal) ||
                //bottom border and dragging down
                (Cursor.Position.Y > this.Location.Y + this.Height - 50 && relativePoint.Y > yOriginal))
            {
                dragItem = null;
                return;
            }


            var newX = relativePoint.X - xOffset_Inner;
            var newY = relativePoint.Y - yOffset_Inner;

            dragItem.Location = new Point(newX, newY);
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            dragItem = null;
        }
    }
}
