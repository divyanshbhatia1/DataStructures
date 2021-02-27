using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataStructures
{
	public interface IDS_Queue<T>
	{
		T Pop();
		void Push(T data);
		string ToString();
	}

	public class DS_Queue<T> : IDS_Queue<T>
	{
		private T[] Data { get; set; }
		private int LastFilledIndex
		{
			get
			{
				for (int i = 0; i < Data.Length; i++)
				{
					if (EqualityComparer<T>.Default.Equals(Data[i], default)) return i - 1;
				}

				return Data.Length - 1;
			}
		}

		public DS_Queue(int length)
		{
			Data = new T[length];
		}

		public T Pop()
		{
			if (LastFilledIndex == 0)
			{
				throw new InvalidOperationException("No element to pop");
			}

			var poppedElement = Data[0];

			for (int i = 0; i < LastFilledIndex; i++)
			{
				Data[i] = Data[i + 1];
			}

			Data[LastFilledIndex] = default;

			return poppedElement;
		}

		public void Push(T data)
		{
			if (LastFilledIndex == Data.Length - 1)
			{
				throw new OutOfMemoryException("No memory left");
			}

			Data[LastFilledIndex + 1] = data;
		}

		public override string ToString()
		{
			StringBuilder str = new StringBuilder();

			for (int i = 0; i <= LastFilledIndex; i++)
			{
				str.Append(Data[i] + "\n");
			}

			return str.ToString();
		}
	}
}
