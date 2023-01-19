
// See https://aka.ms/new-console-template for more information
using GenericHW;

Deck<int> deck = new Deck<int>(40);
for (int i = 0; i < 40; i++)
{
    deck.Add(Random.Shared.Next(1, 20));
}
DiceInt dice = new DiceInt(1, 20);
RandomFighter<int> fighter = new RandomFighter<int>(deck, dice);
fighter.Battle();

