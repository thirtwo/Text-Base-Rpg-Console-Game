using System;
using Text_Based_Rpg_Consoel_Game.Items;

namespace Text_Based_Rpg_Consoel_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon axe = new Weapon("Axe", 200, 10,1);
            Armor armor = new Armor("Armor", 100, 105, 2);
            Console.WriteLine(axe.ItemName.ToString() + " buy price is " + axe.ItemBuyPrice);
            Console.WriteLine(armor.ItemSolidity.ToString() + " item solidity");
            
        }
    }
}
