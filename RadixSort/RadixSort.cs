using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class RadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RadixSort() { }
        public RadixSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            var groups = new List<List<T>>();

            for (int index = 0; index < 10; index++)
                groups.Add(new List<T>());

            int length = GetMaxLength();

            for (int step = 0; step < length; step++)
            {
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                foreach (var group in groups)
                {
                    foreach (var item in group)
                        Items.Add(item);
                }

                foreach (var group in groups)
                    group.Clear();
            }
        }

        private int GetMaxLength()
        {
            var length = 0;

            foreach (var group in Items)
            {
                if (group.GetHashCode() < 0)
                    throw new ArgumentException("Поразрядная сортировка поддерживает только числа. " + nameof(Items));

                var l = group.GetHashCode().ToString().Length;

                if (l > length)
                    length = l;
            }

            return length;
        }
    }
}