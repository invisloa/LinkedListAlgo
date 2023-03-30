using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAlgo
{
	public class ListClass
	{
		ListNode? nodeHead;
		ListNode? nodeTail;

		public ListNode? NodeHead { get => nodeHead; }
		public ListNode? NodeTail { get => nodeTail; }
		public void PrintElements()
		{
			if (nodeHead != null)
			{
				ListNode? currentNode = nodeHead;

				while (currentNode != null)
				{
					currentNode.PrintElement();
					currentNode = currentNode.NextNode;
				}
			}
			else
			{
                Console.WriteLine("Hmm isn't Your list kinda... empty");
            }
		}
		public void InitializeNewList(params int[] values)
		{
			for (int i = 0; i < values.Length; i++)
			{
				if (i == 0)
				{
					nodeHead = new ListNode(values[i], null,null);
					nodeTail = nodeHead;
				}
				else
				{
					nodeTail.NextNode = new ListNode(values[i], null, nodeTail);
					nodeTail = nodeTail.NextNode;
				}
			}
		}
		public void AddElement(int value)
		{
			ListNode? currentNode = nodeHead;

			if (nodeHead == null)
			{
				nodeHead = new ListNode(value, null, null);
				nodeTail = nodeHead;
			}
			else
			{
				nodeTail.NextNode = new ListNode(value, null, nodeTail);
				nodeTail = nodeTail.NextNode;
			}
		}
		public void SearchNode(int value)
		{
			int? index = 0;
			ListNode? currentNode = nodeHead;
			while (currentNode != null)
			{
				if (currentNode.Value == value)
				{
					Console.WriteLine($"Value is at index {index}");
					return;
				}
				currentNode = currentNode.NextNode;
				index++;

			}
			Console.WriteLine($"There is no {value} value in the list");
		}
		public void RemoveElementOfValue(int value)
		{
			if (nodeHead != null)
			{
				ListNode? currentNode = nodeHead;
				int index = 0;
				if (currentNode.Value == value)
				{
					nodeHead = currentNode.NextNode;
					if (nodeHead != null)
					{
						nodeHead.PrevNode = null;
						Console.WriteLine("NodeHead removed");
						return;
					}
					else
					{
						nodeTail = null;
						Console.WriteLine("List is empty now");
						return;
					}
				}
				else
				{
					while (currentNode != null)
					{
						index++;
						if (currentNode.Value == value)
						{
							ListNode tempNode;

							if (currentNode.NextNode != null)
							{
								currentNode.PrevNode.NextNode = currentNode.NextNode;
								currentNode.NextNode.PrevNode = currentNode.PrevNode;
								Console.WriteLine($"Element at index {index} succesfully removed");
								return;
							}
							else // next is null
							{

								nodeTail = nodeTail.PrevNode;
								nodeTail.NextNode = null;
								Console.WriteLine($"NodeTail succesfully removed");
								return;
							}
						}
						currentNode = currentNode.NextNode;
					}
					Console.WriteLine($"Element of value {value} is not in the list");
				}
			}
		}
		public void PrintHeadAndTail()
		{
            Console.WriteLine($"Head value is {NodeHead}, Tail value is {NodeTail}" );
        }
		public void Prepend(int value)
		{
			if (nodeHead != null) 
			{
				nodeHead.PrevNode = new ListNode(value, nodeHead, null);
				nodeHead = nodeHead.PrevNode;
			}
		}
		public void IndexOf(int indexValue)
		{
			if (nodeHead != null)
			{
				int currentIndex = 0;
				if (indexValue == 0)
				{
					Console.WriteLine($"nodeHead value is {nodeHead.Value}");
				}
				else
				{
					ListNode currentNode = nodeHead;
					while (currentNode != null)
					{
						currentIndex++;
						currentNode = currentNode.NextNode;
						if (currentIndex == indexValue)
						{
							Console.WriteLine($"Element at index {indexValue} is equal to {currentNode.Value}");
							return;
						}
					}
					Console.WriteLine($"There is no element at index {indexValue}.");
					Console.WriteLine("List is too short.");
				}
			}
			else
			{
				Console.WriteLine("But the list is empty....");
			}
		}
	}
}