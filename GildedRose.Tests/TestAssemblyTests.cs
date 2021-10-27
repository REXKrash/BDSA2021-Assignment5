using System.Collections.Generic;
using System.Linq;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{

    public class TestAssemblyTests
    {

        Program app = new Program();
        List<Item> DefaultItemList = new List<Item>
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
            };

        [Fact]
        public void TestTheTruth()
        {
            Assert.True(true);
        }

        [Fact]
        public void UpdateQuality_Given_Standard_Item_Updates_Correctly()
        {
            app.Items = DefaultItemList;
            var dexterityVest = app.Items[0];
            var elixirItem = app.Items[2];
            app.UpdateQuality();

            Assert.Equal(19, dexterityVest.Quality);
            Assert.Equal(9, dexterityVest.SellIn);

            Assert.Equal(6, elixirItem.Quality);
            Assert.Equal(4, elixirItem.SellIn);

            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();

            Assert.Equal(0, elixirItem.Quality);
            Assert.Equal(-1, elixirItem.SellIn);
        }

        [Fact]
        public void UpdateQuality_Given_Cheese_Item_Updates_Correctly()
        {
            app.Items = DefaultItemList;
            var brie = app.Items[1];
            app.UpdateQuality();

            Assert.Equal(1, brie.Quality);
            Assert.Equal(1, brie.SellIn);

            app.UpdateQuality();
            app.UpdateQuality();

            Assert.Equal(4, brie.Quality);
            Assert.Equal(-1, brie.SellIn);
        }

        [Fact]
        public void UpdateQuality_Given_Backstage_Item_Updates_Correctly()
        {
            app.Items = DefaultItemList;
            var backstageItem = new BackstageItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            };
            var backstageItem2 = new BackstageItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 20
            };
            var backstageItem3 = new BackstageItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 20
            };
            app.Items.Add(backstageItem);
            app.Items.Add(backstageItem2);
            app.Items.Add(backstageItem3);

            app.UpdateQuality();

            Assert.Equal(21, backstageItem.Quality);
            Assert.Equal(14, backstageItem.SellIn);

            Assert.Equal(22, backstageItem2.Quality);
            Assert.Equal(9, backstageItem2.SellIn);

            Assert.Equal(23, backstageItem3.Quality);
            Assert.Equal(4, backstageItem3.SellIn);
        }

        [Fact]
        public void UpdateQuality_Given_Conjure_Item_Updates_Correctly()
        {
            app.Items = DefaultItemList;
            var conjuredItem = app.Items[5];
            app.UpdateQuality();

            Assert.Equal(4, conjuredItem.Quality);
            Assert.Equal(2, conjuredItem.SellIn);
        }

        [Fact]
        public void UpdateQuality_Given_Legendary_Item_Updates_Correctly()
        {
            app.Items = DefaultItemList;
            var legendaryItem = app.Items[3];
            app.UpdateQuality();

            Assert.Equal(80, legendaryItem.Quality);
            Assert.Equal(0, legendaryItem.SellIn);
        }
    }
}