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
    internal class PlayerCreate : Scene
    {
        public PlayerCreate()
        {
            Add("###Criação do jogador:");
            Add("Nome escolhido para o jogador:");
        }

        public override Scene Options(string option)
        {
            Console.WriteLine($"Nome escolhido: {option}");

            Player p  = State.GetPlayer();
            p.Name = option;

            return new City();
        }
    }
}
