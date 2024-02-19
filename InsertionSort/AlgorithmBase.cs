using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;

        public List<T> Items { get; set; } = new List<T>();

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwopCount++;
            }
        }

        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;
            timer.Start();

            MakeSort();

            Items.Sort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort() => Items.Sort();
    }
}