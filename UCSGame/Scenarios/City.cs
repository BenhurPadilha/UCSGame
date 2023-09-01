using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class City : Scene
    {
        public City() 
        {
            Add($"A cidade é fria {State.GetPlayer().Name}...");
            Add("Você sente frio...");
            Add("─────────█▄██▄█");
            Add("█▄█▄█▄█▄█▐█┼██▌█▄█▄█▄█▄█");
            Add("███┼█████▐████▌█████┼███");
            Add("█████████▐████▌█████████");
            Add("1 ) Entrar no castelo para se abrigar.");
            Add("2 ) Ir até a loja.");
            Add("3 ) Retornar ao menu");
        }
        public override Scene Options(string option)
        {
            if(option == "1") 
            {
                return new Castle();
            }
            else if (option == "2")
            {
                return new Store();
            }
            return new Menu();
        }
    }
}
