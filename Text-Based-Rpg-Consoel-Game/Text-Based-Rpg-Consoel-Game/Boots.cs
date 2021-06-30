using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Rpg_Consoel_Game.Items
{
    class Boots : Item
    {
        private float speed;

        public float Speed
        {
            get { return speed * Level; }
            set
            {
                if (speed <= 0)
                {
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public Boots(string itemName, float itemBuyPrice, int itemSolidity, float speed)
            : base(itemName, itemBuyPrice, itemSolidity)
        {
            this.speed = speed;
        }
    }
}
