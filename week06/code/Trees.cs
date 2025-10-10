public static class Trees
{
    public static BinarySearchTree CreateTreeFromSortedList(int[] sorted)
    {
        var tree = new BinarySearchTree();
        InsertMiddle(tree, sorted, 0, sorted.Length - 1);
        return tree;
    }

    public static void InsertMiddle(BinarySearchTree tree, int[] sorted, int first, int last)
    {
        if (first > last)
            return;

        int mid = (first + last) / 2;
        tree.Insert(sorted[mid]);

        InsertMiddle(tree, sorted, first, mid - 1);
        InsertMiddle(tree, sorted, mid + 1, last);
    }
}
