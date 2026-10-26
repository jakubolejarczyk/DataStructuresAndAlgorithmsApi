using DataStructuresAndAlgorithmsApi.Models;

namespace DataStructuresAndAlgorithmsApi.Services;

public class SingleLinkedListService
{
    public SingleLinkedListNode? Head { get; set; }

    public void Append(int value)
    {
        var newNode = new SingleLinkedListNode(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            var currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }
    }

    public void Prepend(int value)
    {
        var newNode = new SingleLinkedListNode(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
    }

    public int? Find(int value)
    {
        var currentNode = Head;
        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return currentNode.Value;
            }
            currentNode = currentNode.Next;
        }
        return null;
    }

    public void Remove()
    {
        throw new NotImplementedException();
    }

    public List<int> ToList()
    {
        var currentNode = Head;
        var result = new List<int>();
        while (currentNode != null)
        {
            result.Add(currentNode.Value);
            currentNode = currentNode.Next;
        }
        return result;
    }
}
