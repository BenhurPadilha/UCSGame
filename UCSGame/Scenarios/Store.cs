using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Store : Scene
    {
        public Store()
        {
            Add("Seja bem vindo à nossa loja!");
            Add("░░░░▄██▄░░░░░░░░░");
            Add("░░▄██████▄░░░░░░░");
            Add("░▀██┼██┼██▀░░░░░░");
            Add("▄▄████████▄░░░░░░");
            Add("1 ) Ver lista de produtos.");
            Add("2 ) Voltar para a cidade.");
        }
        public override Scene Options(string option)
        {
            if (option == "1")
            {
                string[] items = new string[]
                {
                    "ROUPAS",
                    "COMIDA",
                    "CARRUAGENS",
                    "ARMAS",
                    "POÇÕES"
                };

                List storeList = new List(items);

                return storeList;
            }

            return new City();
        }
    }
}
