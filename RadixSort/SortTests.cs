﻿using System;
using System.Linq;
using Algorithm.DataStructures;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm
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

            for (int index = 0; index < 100; index++)
                Items.Add(random.Next(0, 100));

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
            var tree = new Tree<int>(Items);

            tree.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], tree.Items[index]);
        }

        [TestMethod]
        public void HeapSortTest()
        {
            var heap = new Heap<int>(Items);
            heap.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], heap.Items[index]);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(Items);
            selection.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], selection.Items[index]);
        }

        [TestMethod]
        public void GnomeSortTest()
        {
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);
            gnome.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], gnome.Items[index]);
        }

        [TestMethod]
        public void RadixSortTest()
        {
            var radix = new RadixSort<int>();
            radix.Items.AddRange(Items);
            radix.Sort();

            for (int index = 0; index < Items.Count; index++)
                Assert.AreEqual(Sorted[index], radix.Items[index]);
        }
    }
} 