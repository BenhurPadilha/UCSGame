using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Components.FightingMoves;

namespace UCSGame.Components.Characters
{
    internal class Player : Character
    {
        public string Bag = "vazio";

        public override FightingMove NextFighntingMove()
        {
            int option = 0;
            do
            {
                Console.WriteLine($"Jogador {State.GetPlayer().Name} escolha um golpe:");
                Console.WriteLine("1) Dar um soco");
                Console.WriteLine("2) Dar um chute");
                Console.WriteLine("3) Defender");

                string userOption = Console.ReadLine();
                try
                {
                    option = Convert.ToInt32(userOption);
                }
                catch (Exception)
                {
                    option = 0;
                    Console.WriteLine("Opção inválida");
                }
                finally
                {
                    if (option < 0 || option > 3)
                    {
                        option = 0;
                        Console.WriteLine("Opção inválida");
                    }
                }

            } while (option == 0);

            if (option == 1)
            {
                return new Punch();
            }
            else if (option == 2)
            {
                return new Kick();
            }
            else
            {
                return new Defend();
            }
        }
    }
}