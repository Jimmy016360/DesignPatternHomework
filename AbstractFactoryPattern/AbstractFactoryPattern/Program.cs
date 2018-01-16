using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Pokemon;
using AbstractFactoryPattern.WarCraft;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 製造寶可夢服裝
            Console.WriteLine("======== 製造寶可夢服裝 ========");
            PokemonCostumeFactory pokemonFactory = new PokemonCostumeFactory();
            CostumeShop shop1 = new CostumeShop(pokemonFactory);
            shop1.Build();

            // 製造魔獸爭霸服裝
            Console.WriteLine("======== 製造魔獸爭霸服裝 ========");
            WarCraftCostumeFactory warCraftCostumeFactory = new WarCraftCostumeFactory();
            CostumeShop shop2 = new CostumeShop(warCraftCostumeFactory);
            shop2.Build();

            Console.ReadKey();
        }
    }
}
