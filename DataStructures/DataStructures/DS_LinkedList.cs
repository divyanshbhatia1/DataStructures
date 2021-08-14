using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataStructures
{
	public interface IDS_LinkedList<T>
	{
		int Length { get; }

		void AddAfterMiddle(T data);
		void AddFirst(T data);
		void AddLast(T data);
		void RemoveAfterMiddle();
		void RemoveFirst();
		void RemoveLast();
		void RemoveWhere(T data);
		void Traverse();
	}

	public class DS_LinkedList<T> : IDS_LinkedList<T>
	{
		private Node<T> Head { get; set; }

		public DS_LinkedList(T data)
		{
			var node = new Node<T>()
			{
				Data = data
			};

			Head = node;
		}

		public DS_LinkedList()
		{ }

		public void AddFirst(T data)
		{
			var node = new Node<T>()
			{
				Data = data,
				Next = Head
			};

			Head = node;
		}

		public void AddLast(T data)
		{
			var node = new Node<T>()
			{
				Data = data
			};

			var last = GetLast();

			last.Next = node;
		}

		public void AddAfterMiddle(T data)
		{
			var node = new Node<T>
			{
				Data = data
			};

			var middle = GetMiddle();

			node.Next = middle.Next;

			middle.Next = node;
		}

		public void RemoveFirst()
		{
			Head = Head.Next;
		}

		public void RemoveLast()
		{
			if (Head.Next == null)
			{
				Head = null;
				return;
			}

			var node = Head;

			while (node.Next.Next != null)
			{
				node = node.Next;
			}

			node.Next = null;
		}

		public void RemoveAfterMiddle()
		{
			var middle = GetMiddle();

			middle.Next = middle.Next.Next;
		}

		public void RemoveWhere(T data)
		{
			if (Head.Data.Equals(data))
			{
				RemoveFirst();
			}

			var node = Head;

			while (node != null && node.Next != null)
			{
				if (node.Next.Data.Equals(data))
				{
					node.Next = node.Next.Next;
				}

				node = node.Next;
			}
		}

		public int Length
		{
			get
			{
				int count = 0;
				var node = Head;
				while (node != null)
				{
					count++;
					node = node.Next;
				}
				return count;
			}
		}

		private Node<T> GetMiddle()
		{
			var fastPtr = Head;

			var slowPtr = Head;

			while (fastPtr.Next != null && fastPtr.Next.Next != null)
			{
				fastPtr = fastPtr.Next.Next;

				slowPtr = slowPtr.Next;
			}

			return slowPtr;
		}

		public void Traverse()
		{
			var node = Head;

			while (node != null)
			{
				Console.WriteLine(node.Data);
				node = node.Next;
			}
		}

		private Node<T> GetLast()
		{
			var node = Head;

			while (node.Next != null)
			{
				node = node.Next;
			}

			return node;
		}

	}
	public class Node<TNode>
	{
		public TNode Data { get; set; }
		public Node<TNode> Next { get; set; }
	}
}
