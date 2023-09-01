using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Components.FightingMoves
{
    internal class Punch : FightingMove
    {
        public override int GetDamage()
        {
            return 10;
        }

        public override int GetDefense()
        {
            return 0;
        }

        public override string GetName()
        {
            return "Socar";
        }
    }
}