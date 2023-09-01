using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Components.FightingMoves
{
    internal class Defend : FightingMove
    {
        public override int GetDamage()
        {
            return 0;
        }

        public override int GetDefense()
        {
            return 100;
        }
        public override string GetName()
        {
            return "Defender";
        }
    }
}