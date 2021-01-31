using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Operations
{
	public static class Search
	{
		public static int LinearSearch(int[] array, int item)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == item)
					return (i + 1);
			}

			return -1;
		}

		public static int BinarySearch(int[] array, int item)
		{
			int min = 0;
			int max = array.Length - 1;
			int mid;
			int midItem;

			while (min <= max)
			{
				mid = (max + min) / 2;

				midItem = array[mid];

				if (midItem == item)
				{
					return mid + 1;
				}

				if (item < midItem)
				{
					max = mid - 1;
				}

				if (item > midItem)
				{
					min = mid + 1;
				}
			}

			return -1;
		}

		public static int JumpSearch(int[] array, int item)
		{
			int jumpSize = Convert.ToInt32(Math.Ceiling(Math.Sqrt(array.Length)));

			int min = 0;
			int max = array.Length;

			for(int i = 0; i < array.Length; i += jumpSize)
			{
				if(item < array[i])
				{
					max = i;
					break;
				}
				min = i;
			}

			for(int i = min; i < max; i ++)
			{
				if (array[i] == item) return i + 1;
			}

			return -1;
		}
	}
}
