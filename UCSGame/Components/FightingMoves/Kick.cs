using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Components.FightingMoves
{
    internal class Kick : FightingMove
    {
        public override int GetDamage()
        {
            return 20;
        }

        public override int GetDefense()
        {
            return 0;
        }

        public override string GetName()
        {
            return "Chutar";
        }
    }
}