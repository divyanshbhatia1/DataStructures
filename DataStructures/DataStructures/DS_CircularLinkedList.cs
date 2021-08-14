using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataStructures
{
	public class DS_CircularLinkedList<T> //Singly
	{
		private Node<T> Head { get; set; }

		public void AddFirst(T data)
		{
			Node<T> last = GetLast();

			var node = new Node<T>()
			{
				Data = data,
				Next = Head
			};

			Head = node;

			if (last == null)
				last = GetLast();

			last.Next = Head;
		}

		public void Traverse()
		{
			var node = Head;
			do
			{
				Console.Write(node.Data + ", ");
				node = node.Next;
			}
			while (node.Next != null && node != Head);
		}

		private Node<T> GetLast()
		{
			if (Head == null) return null;

			var node = Head;

			do
			{
				if (node.Next != null)
					node = node.Next;
			}
			while (node.Next != null && node.Next != Head);

			return node;
		}
	}
}
