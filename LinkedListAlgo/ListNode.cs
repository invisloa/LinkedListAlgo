using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAlgo
{ 
	public class ListNode
	{
		public int value;
		public ListNode? nextNode;
		public ListNode? prevNode;
		public ListNode(int value, ListNode? nextNode, ListNode? prevNode)
			{
				this.value = value;
				this.nextNode = nextNode;
				this.prevNode = prevNode;
			}

		public override string ToString()
			{
				return value.ToString();
			}

		public void PrintElement()
			{
				Console.WriteLine(this.ToString());
			}
	}
}

