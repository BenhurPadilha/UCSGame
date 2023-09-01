using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Components.FightingMoves;

namespace UCSGame.Components.Characters
{
    internal class Enemy : Character
    {
        public Random Rnd = new Random();

        public Enemy(string name)
        {
            Name = name;
        }

        public override FightingMove NextFighntingMove()
        {
            FightingMove[] fightingMoves = new FightingMove[]
            {
                new Punch(),
                new Kick(),
                new Defend()
            };

            Console.WriteLine("O inimigo está pensando...");
            Thread.Sleep(2000);

            return fightingMoves[Rnd.Next(0, fightingMoves.Length)];
        }
    }
}
