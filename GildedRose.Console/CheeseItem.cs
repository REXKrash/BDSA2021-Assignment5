using System.Collections.Generic;

namespace GildedRose.Console
{
    public class CheeseItem : Item
    {
        override public void Update()
        {
            SellIn -= 1;

            if (SellIn < 0) Quality += 2;
            else Quality += 1;

            if (Quality >= 50) Quality = 50;
        }
    }
}
