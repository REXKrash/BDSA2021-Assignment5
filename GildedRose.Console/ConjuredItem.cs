using System.Collections.Generic;

namespace GildedRose.Console
{
    public class ConjuredItem : Item
    {
        override public void Update()
        {
            Quality--;
            base.Update();
        }
    }
}
