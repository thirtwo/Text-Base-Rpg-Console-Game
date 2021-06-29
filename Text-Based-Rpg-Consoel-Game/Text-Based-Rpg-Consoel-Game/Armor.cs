using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Rpg_Consoel_Game.Items
{
    class Armor : Item
    {
        private float armour;

        public float Armour
        {
            get { return armour * Level; }
            set
            {
                if (armour <= 0)
                {
                    armour = 0;
                }
                else
                {
                    armour = value;
                }
            }
        }


        public Armor(string itemName, float itemBuyPrice, int itemSolidity, float armour)
            : base(itemName, itemBuyPrice, itemSolidity)
        {
            Armour = armour;
        }
    }
}
