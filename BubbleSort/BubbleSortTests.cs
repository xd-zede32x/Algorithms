using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            var random = new Random();
            var items = new List<int>();

            for (int index = 0; index < 800; index++)
            {
                items.Add(random.Next(0, 100));
            }

            bubble.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            bubble.Sort();

            for (int index = 0; index < items.Count; index++)
            {
                Assert.AreEqual(sorted[index], bubble.Items[index]);
            }
        }
    }
}