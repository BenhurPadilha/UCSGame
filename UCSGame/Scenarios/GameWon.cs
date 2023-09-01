using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class GameWon : Scene
    {
        public GameWon() 
        {
            Add($"O dragão está morto! Parabéns, {State.GetPlayer().Name} você venceu!");
            Add("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Add("$$$$$$$$$$$$$$$$Y/'$$$$P'a$$$$$$$$$$$$$$$$");
            Add("$$$$$$$$$\",` /,/,mT$$$$ d$$$$$$$$$$$$$$$$");
            Add("$$$$$l',` , '/d$$$$P^$a `^a`W$$$$$$$$$$$$$");
            Add("$$l', ` ,   |d$$$P^$'   _  _ ==~a$$$$$$$$$");
            Add("$l.`  .     \'i$^4'   _eP$$$$$$$$$$$$$$$$$");
            Add("l '  .         /   ,  $$$$' `$~$$$$$$$$$$$");
            Add("; ' ,              l /^' .,$oa$$$$$$$$$$$$");
            Add("b ' ,        .     (_ ,1$$$$$$'$$$$$$$$$$$");
            Add("$ , ,      .;       _$$$$$$$P $a$$$$$$$$$$");
            Add("$, ,`    .$Ly        lM\"^ ,  ,$$$$$$$'$$$");
            Add("$$, ,`   d$Liy      /'   edb $$$$$$$'$$$$$");
            Add("$$$$,,'. $$$Li     (    d$$$$$$$$$$'$$$$$$");
            Add("$$$$$$,' v$$$Li4.   `  `Q$$$$$$$P',$$$$$$$");
            Add("$$$$$$$$,$$$$$$$L44., . .     ,,;d$$$$$$$$");
            Add("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Add("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }

        public override Scene Options(string option)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
