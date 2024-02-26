using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public GnomeSort() { }
        public GnomeSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            var index = 1;

            while (index < Items.Count)
            {
                if (index == 0 || Compare(Items[index], Items[index - 1]) == 1 || Compare(Items[index], Items[index - 1]) == 0)
                    index++;

                else
                {
                    Swop(index, index - 1);
                    index--;
                }   
            }
        }
    }
}