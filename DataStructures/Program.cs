using DataStructures.DataStructures;
using DataStructures.Operations;
using System;

namespace DataStructures
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] array = { 1, 2, 3, 4, 5 };

			//int itemIndex = Search.LinearSearch(array, 10);

			//int itemIndex = Search.BinarySearch(array, 0);

			//int itemIndex = Search.JumpSearch(array, 2);

			//Console.WriteLine($"Item present at {itemIndex}");

			//int[] unsortedArray = { 4, 3, 2, 1, /*9, 7, 5, 91, 150, 0, 25, 2, 11, 12, 9, 3*/ };

			//var sortedArray = Sort.SelectionSort(unsortedArray);

			//var sortedArray = Sort.BubbleSort(unsortedArray);

			//var sortedArray = Sort.InsertionSort(unsortedArray);

			//var sortedArray = Sort.MergeSort(unsortedArray);

			//var sortedArray = Sort.HeapSort(unsortedArray);

			//for (int i = 0; i < sortedArray.Length; i++) Console.Write($"{sortedArray[i]} \t");

			//var linkedList = new DS_LinkedList<int>(1);

			//linkedList.AddLast(10);

			//linkedList.AddLast(15);

			//linkedList.AddAfterMiddle(11);

			//Console.WriteLine(linkedList.Length);

			var stack = new DS_Stack<int>(4);

			stack.Push(1);

			stack.Push(2);

			Console.WriteLine("Popped: " + stack.Pop());

			Console.WriteLine(stack);
		}
	}
}
