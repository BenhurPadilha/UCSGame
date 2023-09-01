using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Components.FightingMoves;

namespace UCSGame.Components.Characters
{
    internal abstract class Character
    {
        public string Name = "";

        public int Life = 100;

        public int Defense = 0;

        public abstract FightingMove NextFighntingMove();

        public void Fight(Character enemy, FightingMove fightingMove)
        {
            Defense = fightingMove.GetDefense();

            if (enemy.Defense == 0)
            {
                enemy.Life -= fightingMove.GetDamage();
                if (enemy.Life < 0)
                {
                    enemy.Life = 0;
                }
            }
            else
            {
                enemy.Defense = 0;
            }
        }
    }
}
