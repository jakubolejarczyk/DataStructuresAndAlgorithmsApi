using DataStructuresAndAlgorithmsApi.Models;

namespace DataStructuresAndAlgorithmsApi.Services;

public class LinkedListService : ILinkedListService
{
    public Node? Head { get; set; }

    public void Append(int value)
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        var tmpNode = Head;
        while (tmpNode.Next != null)
        {
            tmpNode = tmpNode.Next;
        }
        tmpNode.Next = newNode;
    }

    public string GetText()
    {
        var tmpNode = Head;
        if (tmpNode == null)
        {
            return "null";
        }
        string result = "";
        while (tmpNode != null)
        {
            result += tmpNode.Value + " -> ";
            tmpNode = tmpNode.Next;
        }
        result += "null";
        return result;
    }
}
