using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class List : Scene
    {
        public string[] Items;

        public List(string[] items)
        {
            Items = items;

            Add("Itens disponíveis para venda:");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");

            int n = 1;

            foreach (var item in items)
            {
                
                string line = $"█ -> {n}) {item}";
                line = line.PadRight(21, ' ');
                line += "█";
                Add(line);
                n++;
            }
            Add("█--------------------█");
            Add("█ -> 0) Sair         █");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
        }
        public override Scene Options(string option)
        {
            if (option == "0")
            {
                return new Store();
            }
            return new Menu();

        }
    }
}
