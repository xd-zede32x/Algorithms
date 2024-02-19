using System;

namespace Algorithm.DataStructures
{
    public class Node<T> : IComparable where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                    Left = node;

                else
                    Left.Add(data);
            }

            else
            {
                if (Right == null)
                    Right = node;

                else
                    Right.Add(data);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
                return Data.CompareTo(item);

            else
                throw new ArgumentException("Не совпадение типов");
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}