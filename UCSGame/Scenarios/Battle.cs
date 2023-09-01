using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;
using UCSGame.Components;
using UCSGame.Components.Characters;
using UCSGame.Components.FightingMoves;
using static System.Net.Mime.MediaTypeNames;

namespace UCSGame.Scenarios
{
    internal class Battle : Scene
    {
        int round = 1;

        public Enemy Enemy;

        public Character Who;

        public Scene Previous;

        public Battle(Enemy enemy, Scene previous)
        {
            Enemy = enemy;

            Previous = previous;

            Who = WhoPlay();

            Add($"Você é ousado, {State.GetPlayer().Name}! Desejou enfrentar o grande dragão! Que a sorte esteja com você!!!");
            Add($"Muita atenção, {State.GetPlayer().Name}!!! A batalha está em andamento!");
            Add("Pressione Enter para continuar...");
        }

        public Character WhoPlay()
        {
            if (round % 2 == 1)
            {
                return State.GetPlayer();
            }
            else
            {
                return Enemy;
            }
        }

        public Character NextTurn()
        {
            if (Who == Enemy)
            {
                return State.GetPlayer();
            }
            else
            {
                return Enemy;
            }
        }

        public override Scene Options(string option)
        {
            Player player = State.GetPlayer();



            while (player.Life > 0 && Enemy.Life > 0)
            {
                FightingMove fightingMove = Who.NextFighntingMove();
                Console.WriteLine($"O jogador {Who.Name} escolheu {fightingMove.GetName()}");

                Character Next = NextTurn();
                Who.Fight(Next, fightingMove);

                Console.WriteLine($"Jodador {State.GetPlayer().Name} tem {State.GetPlayer().Life} de vida.");
                Console.WriteLine($"Jodador {Enemy.Name} tem {Enemy.Life} de vida.");
                Console.WriteLine("-----------------------------");

                Who = Next;

                if (player.Life <= 0)
                {
                    return new GameOver();
                }

                if (Enemy.Life <= 0)
                {
                    return new GameWon();
                }

                Console.WriteLine("-----------------------------");

                round++;
            }

            return Previous;
        }
    }
}
