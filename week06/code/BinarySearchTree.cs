using System.Collections;
using System.Collections.Generic;

public class BinarySearchTree : IEnumerable<int>
{
    private Node? _root;

    public void Insert(int value)
    {
        if (_root is null)
            _root = new Node(value);
        else
            _root.Insert(value);
    }

    public bool Contains(int value)
    {
        return _root?.Contains(value) ?? false;
    }

    public int GetHeight()
    {
        return _root?.GetHeight() ?? 0;
    }

    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }

    public IEnumerator<int> GetEnumerator()
    {
        var values = new List<int>();
        TraverseForward(_root, values);
        foreach (var value in values)
            yield return value;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private void TraverseForward(Node? node, List<int> values)
    {
        if (node is null) return;
        TraverseForward(node.Left, values);
        values.Add(node.Data);
        TraverseForward(node.Right, values);
    }

    public IEnumerable Reverse()
    {
        var values = new List<int>();
        TraverseBackward(_root, values);
        foreach (var value in values)
            yield return value;
    }

    private void TraverseBackward(Node? node, List<int> values)
    {
        if (node is null) return;
        TraverseBackward(node.Right, values);
        values.Add(node.Data);
        TraverseBackward(node.Left, values);
    }
}

public static class IntArrayExtensionMethods
{
    public static string AsString(this IEnumerable array)
    {
        return "<IEnumerable>{" + string.Join(", ", array.Cast<int>()) + "}";
    }
}
