using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAlgo
{ 
	public class ListNode
	{
		private int _value;
		private ListNode? _nextNode;
		private ListNode? _prevNode;

		public int Value {get => _value; set => _value = value;}

		public ListNode? NextNode{get => _nextNode; set => _nextNode = value;}

		public ListNode? PrevNode{get => _prevNode; set => _prevNode = value;}
		public ListNode(int value, ListNode? nextNode, ListNode? prevNode)
		{
			Value = value;
			NextNode = nextNode;
			PrevNode = prevNode;
		}
		public override string ToString()
			{
				return Value.ToString();
			}

		public void PrintElement()
			{
				Console.WriteLine(this.ToString());
			}
	}
}

