using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Components.FightingMoves
{
    internal abstract class FightingMove
    {
        public abstract string GetName();

        public abstract int GetDamage();

        public abstract int GetDefense();
    }
}
