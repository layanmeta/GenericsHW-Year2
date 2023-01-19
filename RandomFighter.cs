using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    internal class RandomFighter<T> where T : struct, IComparable<T>
    {
        readonly Deck<T> _deck;
        readonly Dice<T> _dice;

        public RandomFighter(Deck<T> deck, Dice<T> dice)
        {
            this._deck = deck;
            this._dice = dice;
        }

        public void Battle()
        {
            int dieWins =0;
            int deckWins =0;
            int tie = 0;

            while (_deck.StartingList.Count > 0)
            {
                T diceResult = _dice.Roll();
                T cardDrawn = _deck.StartingList[0];
                T deckResult;

                _deck.TryDraw(cardDrawn);
                deckResult = cardDrawn;

                int compareResult = diceResult.CompareTo(deckResult);

                if (compareResult > 0)
                {
                    dieWins++;
                }
                else if (compareResult < 0)
                {
                    deckWins++;
                }
                else
                {
                    tie++;
                }
            }
            Print(dieWins, deckWins, tie);
        }

        private void Print(int dieWins, int DeckWins, int tie)
        {
            Console.WriteLine($"Die wins: {dieWins}, Deck wins: {DeckWins}, Tie: {tie}");
        }
    }
}
