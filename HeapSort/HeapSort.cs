using System;
using Algorithm.DataStructures;
using System.Collections.Generic;

namespace Algorithm
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public HeapSort(IEnumerable<T> items) : base(items) { }

        public HeapSort() { }
        
        protected override void MakeSort()
        {
            var heap = new HeapStruct<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}   