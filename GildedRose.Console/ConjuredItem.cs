using System.Collections.Generic;

namespace GildedRose.Console
{
    public class ConjuredItem : Item
{
    


        override
    public void Update(){
        Quality -= 2;
        SellIn -=1;

        if(Quality <= 0)
        {
            Quality = 0;
        }
        if(Quality >= 50)
        {
            Quality = 50;
        }
        } 
}
}
