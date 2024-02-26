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

        public event EventHandler<Tuple<T, T>> SwopEvent;
        public event EventHandler<Tuple<T, T>> CompareEvent;

        public AlgorithmBase() { }
        public AlgorithmBase(IEnumerable<T> items) => Items.AddRange(items);

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                SwopEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
                SwopCount++;    

                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
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

        public int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            ComparisonCount++;
            return a.CompareTo(b);
        }
    }
}