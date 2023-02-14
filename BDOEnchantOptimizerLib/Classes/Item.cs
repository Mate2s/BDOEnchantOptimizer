using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOEnchantOptimizerLib
{
    public class Item
    {
        private double price;
        private int lvl;
        private Grade grade;
        private ItemType itemType;

        public Item()
        {
            this.price = 0;
            this.lvl = 0;
            this.grade = Grade.Green;
            this.ItemType = ItemType.Armor;
        }

        public Item(double price, int lvl, Grade grade, ItemType ItemType)
        {
            this.price = price;
            this.lvl = lvl;
            this.grade = grade;
            this.ItemType= ItemType;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }

        public Grade Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public ItemType ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
    }
}
