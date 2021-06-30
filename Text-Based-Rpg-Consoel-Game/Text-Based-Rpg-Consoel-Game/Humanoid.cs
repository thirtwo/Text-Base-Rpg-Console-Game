using System;
using System.Collections.Generic;
using System.Text;
using Text_Based_Rpg_Consoel_Game.Items;

namespace Text_Based_Rpg_Consoel_Game.Humanoids
{
    class Humanoid
    {
        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private bool isAlive = true;

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
        private int experience = 0;

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }



        private float constitution;

        public float Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }

        private int strength;

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private int defence;

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }
        private int dexterity;

        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        private float health;
        private float armor;
        private float damage;
        private float speed;
        public float Health { get => health; set => health = value; }
        public float Armor { get => armor + activeArmor.Armour; }
        public float Damage { get => damage + activeWeapon.Damage; }
        public float Speed { get => speed + boots.Speed; }

        public Weapon activeWeapon;
        public Armor activeArmor;
        public Boots boots;


        public void SetStats()
        {
            health = constitution * level;
            armor = defence * level;
            damage = strength * level;
            speed = dexterity * level;
        }

        private int maxExp()
        {
            return 10 * (int)MathF.Pow((1 + level), 2);
        }

    }
}
