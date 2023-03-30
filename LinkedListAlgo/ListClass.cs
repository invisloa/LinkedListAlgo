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
					currentNode = currentNode.nextNode;
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
					nodeTail.nextNode = new ListNode(values[i], null, nodeTail);
					nodeTail = nodeTail.nextNode;
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
				nodeTail.nextNode = new ListNode(value, null, nodeTail);
				nodeTail = nodeTail.nextNode;
			}
		}
		public void SearchNode(int value)
		{
			int? index = 0;
			ListNode? currentNode = nodeHead;
			while (currentNode != null)
			{
				if (currentNode.value == value)
				{
					Console.WriteLine($"Value is at index {index}");
					return;
				}
				currentNode = currentNode.nextNode;
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
				if (currentNode.value == value)
				{
					nodeHead = currentNode.nextNode;
					if (nodeHead != null)
					{
						nodeHead.prevNode = null;
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
						if (currentNode.value == value)
						{
							ListNode tempNode;

							if (currentNode.nextNode != null)
							{
								currentNode.prevNode.nextNode = currentNode.nextNode;
								currentNode.nextNode.prevNode = currentNode.prevNode;
								Console.WriteLine($"Element at index {index} succesfully removed");
								return;
							}
							else // next is null
							{

								nodeTail = nodeTail.prevNode;
								nodeTail.nextNode = null;
								Console.WriteLine($"NodeTail succesfully removed");
								return;
							}
						}
						currentNode = currentNode.nextNode;
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
				nodeHead.prevNode = new ListNode(value, nodeHead, null);
				nodeHead = nodeHead.prevNode;
			}
		}
		public void IndexOf(int indexValue)
		{
			if (nodeHead != null)
			{
				int currentIndex = 0;
				if (indexValue == 0)
				{
					Console.WriteLine($"nodeHead value is {nodeHead.value}");
				}
				else
				{
					ListNode currentNode = nodeHead;
					while (currentNode != null)
					{
						currentIndex++;
						currentNode = currentNode.nextNode;
						if (currentIndex == indexValue)
						{
							Console.WriteLine($"Element at index {indexValue} is equal to {currentNode.value}");
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