using System.Collections.Generic;

namespace GildedRose.Console
{
    public class CommonItem : Item
{
    


        override
    public void Update(){
        Quality -= 1;
        SellIn -=1;
        
        if(Quality <= 0)
        {
            Quality = 0;
        } else if (Quality >= 50){Quality = 50;}
        } 
}
}
