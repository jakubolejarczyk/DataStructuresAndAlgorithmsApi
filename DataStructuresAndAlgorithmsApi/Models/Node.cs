namespace DataStructuresAndAlgorithmsApi.Models;

public class Node(int value)
{
    public int Value { get; set; } = value;

    public Node? Next { get; set; }
}
