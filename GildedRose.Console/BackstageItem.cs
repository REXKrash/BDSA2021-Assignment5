using System.Collections.Generic;

namespace GildedRose.Console
{
    public class BackstageItem : Item
    {
        override public void Update()
        {
            SellIn -= 1;

            if (SellIn > 10) Quality += 1;
            else if (SellIn > 5) Quality += 2;
            else Quality += 3;

            if (Quality >= 50) Quality = 50;
            // Can be made into switch statement
        }
    }
}
