using DataStructures.Operations;
using System;

namespace DataStructures
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 4, 5 };

			//int itemIndex = Search.LinearSearch(array, 10);

			//int itemIndex = Search.BinarySearch(array, 0);

			//int itemIndex = Search.JumpSearch(array, 2);

			//Console.WriteLine($"Item present at {itemIndex}");

			int[] unsortedArray = { 4, 3, 2, 1, 9, 7, 5, 91, 150, 0, 25, 2, 11, 12, 9, 3 };

			//var sortedArray = Sort.SelectionSort(unsortedArray);

			//var sortedArray = Sort.BubbleSort(unsortedArray);

			var sortedArray = Sort.InsertionSort(unsortedArray);

			//var sortedArray = Sort.MergeSort(unsortedArray);

			for (int i = 0; i < sortedArray.Length; i++) Console.Write($"{sortedArray[i]} \t");
		}
	}
}
