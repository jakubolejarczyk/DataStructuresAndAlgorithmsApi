namespace DataStructuresAndAlgorithmsApi.Models;

public class SingleLinkedListNode(int value)
{
    public int Value { get; set; } = value;

    public SingleLinkedListNode? Next { get; set; }
}
