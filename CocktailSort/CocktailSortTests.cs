using System;
using Algorithm;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var cocktail = new CocktailSort<int>();

            var random = new Random();
            var items = new List<int>();

            for (int index = 0; index < 10; index++)
            {
                items.Add(random.Next(0, 100));
            }

            cocktail.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            cocktail.Sort();

            for (int index = 0; index < items.Count; index++)
            {
                Assert.AreEqual(sorted[index], cocktail.Items[index]);
            }
        }
    }
}