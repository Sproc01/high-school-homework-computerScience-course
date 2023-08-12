using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestCard_wpf
{
    class Card
    {

        public enum Type { hearts, diamonds, clubs, spades }
        public int Value { get; private set; }
        public Type CardType { get; private set; }
        public Card(Type type, int value)
        {
            CardType = type;
            Value = value;
        }
        public static bool operator >(Card c1, Card c2)
        {
            if (c1.Value > c2.Value)
                return true;
            else if (c1.Value < c2.Value)
                return false;
            else
                return (int)c1.CardType < (int)c2.CardType;
        }
        public static bool operator <(Card c1, Card c2)
        {
            return !(c1 > c2);
        }
        public static bool operator ==(Card c1, Card c2)
        {
            return c1.Value == c2.Value && c1.CardType == c2.CardType;
        }
        public static bool operator !=(Card c1, Card c2)
        {
            return !(c1 == c2);
        }
    }
    class HighestCardGame
    {
        private enum GameState { WIN_1, WIN_2, NULL }
        Random rand = new Random();
        const int deckCount = 52;
        const int CardsForKind = 14;
        const int typeCount = 4;
        public Card player1 { get; private set; }
        public Card player2 { get; private set; }
        GameState winner = GameState.NULL;
        private Card GenerateCard()
        {
            Card.Type type = (Card.Type)rand.Next(typeCount - 1);
            int value = rand.Next(2, CardsForKind + 1);
            return new Card(type, value);
        }
        public void DrawCard()
        {
            if (object.ReferenceEquals(player1, player2))
            {
                player1 = GenerateCard();
                do
                {
                    player2 = GenerateCard();
                } while (player1 == player2);
            }
            if (player1 > player2)
                winner = GameState.WIN_1;
            else
                winner = GameState.WIN_2;
        }
        public string CardString()
        {
            if (ReferenceEquals(player1, player2))
                return null;
            else
            {
                string card1 = string.Format("{0} : {1}", player1.CardType, player1.Value);
                string card2 = string.Format("{0} : {1}", player2.CardType, player2.Value);
                return string.Format("\nTu:\n\t{0}\nPC:\n\t{1}", card1, card2);
            }
        }
        public string StringWinner()
        {
            if (object.ReferenceEquals(player1, player2))
                return null;
            else
            {
                if (winner == GameState.WIN_1)
                    return "\nHai vinto";
                else if (winner == GameState.WIN_2)
                    return "\nHa vinto il PC";
                else
                    return "\nNessun vincitore";
            }
        }
        public void ResetGame()
        {
            player1 = null;
            player2 = null;
            winner = GameState.NULL;
        }
    }
}
