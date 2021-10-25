using System.Collections.Generic;

namespace GildedRose.Console
{
    public abstract class Item
    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void Update(){}


    }  
}