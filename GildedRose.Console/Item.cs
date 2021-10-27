using System.Collections.Generic;

namespace GildedRose.Console
{
    public abstract class Item
    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void Update() {
            SellIn--;
            Quality -= SellIn < 0 ? 2 : 1;

            if (Quality <= 0) Quality = 0;
            else if (Quality >= 50) Quality = 50;
        }


    }
}