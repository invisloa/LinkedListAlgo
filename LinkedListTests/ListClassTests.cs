using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using LinkedListAlgo;

public class ListClassTests
{
	[Fact]
	public void AddElement_ShouldAddElementToList()
	{
		// Arrange
		var list = new ListClass();

		// Act
		list.AddElement(1);
		list.AddElement(2);

		// Assert
		Assert.Equal(1, list.NodeHead?.value);
		Assert.Equal(2, list.NodeTail?.value);
	}

	[Fact]
	public void InitializeNewList_ShouldCreateNewListWithGivenValues()
	{
		// Arrange
		var list = new ListClass();

		// Act
		list.InitializeNewList(1, 2, 3);

		// Assert
		Assert.Equal(1, list.NodeHead?.value);
		Assert.Equal(2, list.NodeHead?.nextNode?.value);
		Assert.Equal(3, list.NodeTail?.value);
	}

	[Fact]
	public void Prepend_ShouldAddElementToTheBeginningOfTheList()
	{
		// Arrange
		var list = new ListClass();
		list.InitializeNewList(1, 2, 3);

		// Act
		list.Prepend(0);

		// Assert
		Assert.Equal(0, list.NodeHead?.value);
		Assert.Equal(1, list.NodeHead?.nextNode?.value);
		Assert.Equal(3, list.NodeTail?.value);
	}

	[Fact]
	public void InitializeNewList_ShouldSetNodeHeadAndNodeTail_ForFirstElement()
	{
		//Arrange
		ListClass list = new ListClass();

		//Act
		list.InitializeNewList(1);

		//Assert
		Assert.NotNull(list.NodeHead);
		Assert.NotNull(list.NodeTail);
		Assert.Equal(1, list.NodeHead?.value);
		Assert.Equal(list.NodeHead, list.NodeTail);
		Assert.Null(list.NodeHead?.prevNode);
		Assert.Null(list.NodeTail?.nextNode);
	}

	[Fact]
	public void InitializeNewList_ShouldSetNodeHeadAndNodeTail_ForMultipleElements()
	{
		//Arrange
		ListClass list = new ListClass();

		//Act
		list.InitializeNewList(1, 2, 3, 4);

		//Assert
		Assert.NotNull(list.NodeHead);
		Assert.NotNull(list.NodeTail);
		Assert.Equal(1, list.NodeHead?.value);
		Assert.Equal(4, list.NodeTail?.value);
		Assert.Null(list.NodeHead?.prevNode);
		Assert.Null(list.NodeTail?.nextNode);
	}

	[Fact]
	public void AddElement_ShouldAddElement_ToTheEndOfTheList()
	{
		//Arrange
		ListClass list = new ListClass();

		//Act
		list.InitializeNewList(1, 2, 3);
		list.AddElement(4);

		//Assert
		Assert.NotNull(list.NodeHead);
		Assert.NotNull(list.NodeTail);
		Assert.Equal(1, list.NodeHead?.value);
		Assert.Equal(4, list.NodeTail?.value);
		Assert.Null(list.NodeHead?.prevNode);
		Assert.Null(list.NodeTail?.nextNode);
	}

	[Fact]
	public void SearchNode_ShouldReturn_IndexOfFirstOccurrenceOfTheValue()
	{
		//Arrange
		ListClass list = new ListClass();
		var stringWriter = new StringWriter();
		Console.SetOut(stringWriter);

		//Act
		list.InitializeNewList(1, 2, 3, 4, 5);
		list.SearchNode(3);

		Assert.Contains("Value is at index 2", stringWriter.ToString());
	}

	[Fact]
	public void RemoveElementOfValue_ShouldRemove_FirstOccurrenceOfTheValue_FromTheList()
	{
		//Arrange
		ListClass list = new ListClass();

		//Act
		list.InitializeNewList(1, 2, 3, 4, 5);
		list.RemoveElementOfValue(3);

		//Assert
		Assert.NotNull(list.NodeHead);
		Assert.NotNull(list.NodeTail);
		Assert.Equal(1, list.NodeHead?.value);
		Assert.Equal(5, list.NodeTail?.value);
		Assert.Null(list.NodeHead?.prevNode);
		Assert.Null(list.NodeTail?.nextNode);
	}
}