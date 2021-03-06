using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Rpg_Consoel_Game.Items
{
    class Weapon : Item
    {
        private float damage;

        public float Damage
        {
            get { return damage * Level; }
            set
            {
                if (damage <= 0)
                {
                    damage = 0.1f;
                }
                else
                {
                    damage = value;
                }
            }
        }


        public Weapon(string itemName, float itemBuyPrice, int itemSolidity, float damage)
            : base(itemName, itemBuyPrice, itemSolidity)
        {
            Damage = damage;
        }



    }
}
