using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;
using UCSGame.Components;
using UCSGame.Components.Characters;

namespace UCSGame.Scenarios
{
    internal class Castle : Scene
    {
        public Castle()
        {
            Add("Você está no castelo agora!");
            Add("Um drgão habita aqui e está prestes a atacá-lo!");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Add("█░░║║║╠─║─║─║║║║║╠─░░█");
            Add("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1 ) Lutar!");
            Add("2 ) Prefiro fugir de volta para a cidade!");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new Battle(new Enemy("Dragonite"), this);
            }
            return new City();
        }
    }
}
