using System.Collections.Generic;

namespace GildedRose.Console
{
    public class BackstageItem : Item
{
    


        override
    public void Update(){

            if(SellIn > 10)
            {
                Quality += 1;
            } 
            else if (SellIn <= 10 && SellIn > 5)
            {
                Quality += 2;
            }
            else if (SellIn >= 5)
            {
               Quality +=3;
            }
            SellIn -= 1;
            
            if(Quality >= 50){Quality = 50;}
// Can be made into switch statement
        } 
}
}
