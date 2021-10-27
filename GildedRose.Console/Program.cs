using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                {
                    new CommonItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new CheeseItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new CommonItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new BackstageItem
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 15,
                            Quality = 20
                        },
                    new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };
            app.UpdateQuality();
            System.Console.ReadKey();
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.Update();
            }
        }
    }
}