using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Rpg_Consoel_Game.Items
{
    public class Item
    {
        private bool isActive = true;
        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }
        private int level = 1;//as defalut

        public int Level
        {
            get { return level; }
            set
            {
                if (level < 1)
                {
                    level = 1;
                }
                else
                {
                    level = value;
                }
            }
        }

        private string itemName;

        public string ItemName
        {
            get
            {
                if (isActive)
                    return itemName;
                else
                    return "Thrash";
            }
        }

        private float itemBuyPrice;

        public float ItemBuyPrice
        {
            get
            {
                return itemBuyPrice * itemSolidity * 0.01f * level;
            }
            set
            {
                itemBuyPrice = value;
            }
        }

        public float ItemSellPrice
        {
            get
            {
                if (isActive)
                    return itemBuyPrice * 0.5f * itemSolidity * 0.01f * level;
                else
                    return 0;
            }
        }

        private int itemSolidity;

        public int ItemSolidity
        {
            get
            {
                if (isActive)
                    return itemSolidity;
                else
                    return 0;
            }
            set
            {
                if (value <= 0)
                {
                    itemSolidity = 0;
                }
                else if (value >= 100)
                {
                    itemSolidity = 100;
                }
                else
                {
                    itemSolidity = value;
                }
            }
        }


        public Item(string itemName, float itemBuyPrice, int itemSolidity)
        {
            this.itemName = itemName;
            this.itemBuyPrice = itemBuyPrice;
            this.itemSolidity = itemSolidity;
        }
    }


}
