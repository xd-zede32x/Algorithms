using Algorithm.DataStructures;
using System;

namespace Algorithm
{
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;




        }
    }
}