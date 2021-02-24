using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataStructures
{
	public class DS_Stack<T>
	{
		private T[] Data;

		private int LastFilledIndex
		{
			get
			{
				for (int i = 0; i < Data.Length; i++)
				{
					if (EqualityComparer<T>.Default.Equals(Data[i], default)) return i - 1;

				}

				throw new OutOfMemoryException("No memory left");
			}
		}

		public DS_Stack(int length)
		{
			Data = new T[length];
		}

		public void Push(T element)
		{
			Data[LastFilledIndex + 1] = element;
		}

		public T Pop()
		{
			if(LastFilledIndex == -1)
			{
				throw new ArgumentNullException("No elements in Stack");
			}

			var data = Data[LastFilledIndex];

			Data[LastFilledIndex] = default;

			return data;
		}

		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			for(int i = LastFilledIndex; i >= 0; i --)
			{
				str.Append(Data[i] + "\n");
			}
			return str.ToString();
		}
	}
}
