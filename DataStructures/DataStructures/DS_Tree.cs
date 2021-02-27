using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataStructures
{

	public class DS_Tree<T>
	{
		private DS_TreeNode<T> Root { get; set; }

		public void Add(T data)
		{
			if (Root == null)
			{
				Root = new DS_TreeNode<T>(data);
				return;
			}

			Root.Add(data);
		}

		public void Tranverse()
		{
			if (Root != null)
			{
				Root.TraverseInOrder();
			}
		}

		public T Search(T data)
		{
			if (Root == null)
			{
				return default;
			}

			DS_TreeNode<T> node = Root.Search(data);
			return node == default ? default : node.Data;
		}

		public T Min()
		{
			if (Root != null)
			{
				return Root.Min().Data;
			}

			return default;
		}

		public T Max()
		{
			if (Root != null)
			{
				return Root.Max().Data;
			}

			return default;
		}

		public void Delete(T data)
		{
			Root = Delete(Root, data);
		}

		private DS_TreeNode<T> Delete(DS_TreeNode<T> subTreeNode, T value)
		{
			if (subTreeNode == null)
			{
				return subTreeNode;
			}

			//Smaller
			if (Compare(value, subTreeNode.Data) < 0)
			{
				subTreeNode.LeftChild = Delete(subTreeNode.LeftChild, value);
			}

			//Greater
			else if (Compare(value, subTreeNode.Data) > 0)
			{
				subTreeNode.RightChild = Delete(subTreeNode.RightChild, value);
			}

			else
			{
				if (subTreeNode.LeftChild == null)
				{
					return subTreeNode.RightChild;
				}

				if (subTreeNode.RightChild == null)
				{
					return subTreeNode.LeftChild;
				}

				subTreeNode.Data = subTreeNode.RightChild.Min().Data;

				subTreeNode.RightChild = Delete(subTreeNode.RightChild, subTreeNode.Data);
			}


			return subTreeNode;
		}

		private int Compare(T a, T b)
		{
			var ac = a as IComparable;
			var bc = b as IComparable;

			if (ac == null || bc == null)
				throw new NotSupportedException();

			return ac.CompareTo(bc);
		}
	}

	public class DS_TreeNode<TNode>
	{
		public DS_TreeNode()
		{ }

		public DS_TreeNode(TNode data)
		{
			Data = data;
		}

		public TNode Data { get; set; }

		public DS_TreeNode<TNode> LeftChild { get; set; }

		public DS_TreeNode<TNode> RightChild { get; set; }

		public void Add(TNode data)
		{
			//Smaller
			if (Compare(data, Data) < 0)
			{
				if (LeftChild == null)
				{
					LeftChild = new DS_TreeNode<TNode>(data);
					return;
				}

				LeftChild.Add(data);
			}

			//Greater
			if (Compare(data, Data) > 0)
			{
				if (RightChild == null)
				{
					RightChild = new DS_TreeNode<TNode>(data);
					return;
				}
				RightChild.Add(data);
			}
		}

		public void TraverseInOrder()
		{
			if (LeftChild != null)
			{
				LeftChild.TraverseInOrder();
			}
			Console.Write($"{Data}, ");
			if (RightChild != null)
			{
				RightChild.TraverseInOrder();
			}
		}

		public DS_TreeNode<TNode> Search(TNode data)
		{
			//Smaller
			if (Compare(data, Data) < 0)
			{
				return LeftChild.Search(data);
			}

			//Greater
			if (Compare(data, Data) > 0)
			{
				return RightChild.Search(data);
			}

			//Equal
			if (data.Equals(Data))
			{
				return this;
			}

			return default;
		}

		public DS_TreeNode<TNode> Min()
		{
			if (LeftChild != null)
			{
				return LeftChild.Min();
			}

			return this;
		}

		public DS_TreeNode<TNode> Max()
		{
			if (RightChild != null)
			{
				return RightChild.Max();
			}

			return this;
		}

		private int Compare(TNode a, TNode b)
		{
			var ac = a as IComparable;
			var bc = b as IComparable;

			if (ac == null || bc == null)
				throw new NotSupportedException();

			return ac.CompareTo(bc);
		}
	}
}
