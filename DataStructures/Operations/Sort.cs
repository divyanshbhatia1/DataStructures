using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Operations
{
	public static class Sort
	{
		public static int[] SelectionSort(int[] array)
		{
			int[] localarray = Copy(array);

			for(int i = 0; i < localarray.Length; i ++)
			{
				int min = localarray[i];

				for(int j = i; j < localarray.Length; j++ )
				{
					if(localarray[j] < min)
					{
						min = localarray[j];

						Swap(localarray, i, j);
					}
				}
			}

			return localarray;
		}

		public static int[] BubbleSort(int[] array)
		{
			int[] localarray = Copy(array);

			for (int i = 0; i < localarray.Length - 1; i ++)
			{
				for(int j = 0; j < localarray.Length - (i + 1); j ++)
				{
					if(localarray[j] > localarray[j + 1])
					{
						Swap(localarray, j, j + 1);
					}
				}
			}

			return localarray;
		}

		public static int[] InsertionSort(int[] array)
		{
			int[] localArray = Copy(array);

			for (int i = 0; i < localArray.Length; i ++)
			{
				int element = localArray[i];

				int itemPosition = i;

				for (int j = 0; j < i; j ++)
				{
					if(localArray[j] > element)
					{
						itemPosition = j;
						break;
					}
				}

				for(int k= i; k > itemPosition; k --)
				{
					localArray[k] = localArray[k - 1];
				}

				////element should be put at j and other elements should be moved
				//for (int k = itemPosition; k < i; k++)
				//{
				//	localArray[k + 1] = localArray[k];
				//}

				localArray[itemPosition] = element;
			}

			return localArray;
		}

		#region Merge Sort

		public static int[] MergeSort(int[] array)
		{
			var localArray = Copy(array);

			MergeSortInternal(localArray, 0, localArray.Length - 1);

			return localArray;
		}

		private static void MergeSortInternal(int[] array, int start, int end)
		{
			if(start >= end)
			{
				return;
			}

			int mid = (start + end) / 2;

			MergeSortInternal(array, start, mid);
			MergeSortInternal(array, mid + 1, end);

			Merge(array, start, mid, end);
		}

		private static void Merge(int[] array, int start, int mid, int end)
		{
			int leftArraySize = mid - start + 1;
			int[] leftArray = new int[leftArraySize];

			int rightArraySize = end - mid;
			int[] rightArray = new int[rightArraySize];

			//Copy to left and right from array
			int index = 0;
			for(int i = start; i <= mid; i++) leftArray[index++] = array[i];

			index = 0;
			for (int i = mid + 1; i <= end; i++) rightArray[index++] = array[i];


			//Check values and write in array
			int leftIndex = 0;
			int rightIndex = 0;
			int arrayIndex = start;

			while(leftIndex < leftArraySize && rightIndex < rightArraySize)
			{
				if(leftArray[leftIndex] < rightArray[rightIndex])
				{
					array[arrayIndex] = leftArray[leftIndex];
					leftIndex++;
				}
				if (rightArray[rightIndex] < leftArray[leftIndex])
				{
					array[arrayIndex] = rightArray[rightIndex];
					rightIndex++;
				}
				arrayIndex++;
			}

			while(leftIndex < leftArraySize)
			{
				array[arrayIndex] = leftArray[leftIndex];
				arrayIndex++;
				leftIndex++;
			}

			while (rightIndex < rightArraySize)
			{
				array[arrayIndex] = rightArray[rightIndex];
				arrayIndex++;
				rightIndex++;
			}
		}

		#endregion

		public static int[] HeapSort(int[] array)
		{
			var localArray = Copy(array);

			for(int i = 0; i < localArray.Length; i ++)
			{
				Console.Write(localArray[i] + "\t");
			}

			return localArray;
		}

		#region Utilities

		private static int[] Copy(int[] array)
		{
			int[] localarray = new int[array.Length];

			Array.Copy(array, localarray, localarray.Length);

			return localarray;
		}

		private static void Swap(int[] array, int index1, int index2)
		{
			int temp = array[index1];
			array[index1] = array[index2];
			array[index2] = temp;
		}

		#endregion
	}
}
