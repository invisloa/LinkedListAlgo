// See https://aka.ms/new-console-template for more information

using LinkedListAlgo;

ListClass listToOperate = new ListClass();

listToOperate.InitializeNewList(1,2,3,4,5,6,7);


listToOperate.PrintElements();
listToOperate.RemoveElementOfValue(7);
listToOperate.PrintElements();
listToOperate.Prepend(0);
//listToOperate.AddElement(8);
listToOperate.PrintElements();
listToOperate.PrintHeadAndTail();




