using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
    
namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random random = new Random();

        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();

            for (int index = 0; index < 10000; index++)
                Items.Add(random.Next(0, 1000));

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);
            bubble.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], bubble.Items[index]);
        }

        [TestMethod]
        public void CocktailSortTest()
        {
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);
            cocktail.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], cocktail.Items[index]);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            var insert = new InsertionSort<int>();
            insert.Items.AddRange(Items);
            insert.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], insert.Items[index]);
        }

        [TestMethod]
        public void ShellSortTest()
        {
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);
            bases.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], bases.Items[index]);
        }

        [TestMethod]
        public void BaseSortTest()
        {
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);
            shell.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], shell.Items[index]);
        }

        [TestMethod]
        public void TreeSortTest()
        {
            var tree = new TreeSort<int>();
            tree.Items.AddRange(Items);
            tree.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], tree.Items[index]);
        }

        [TestMethod]
        public void HeapSortTest()
        {
            var heap = new HeapSort<int>();
            heap.Items.AddRange(Items);
            heap.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], heap.Items[index]);
        }
    }
}