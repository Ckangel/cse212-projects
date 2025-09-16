using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    public static double[] MultiplesOf(double value, int count)
    {
        // Step 1: Create an array to hold the result
        double[] result = new double[count];
        // Step 2: Loop through from 1 to length
        for (int i = 0; i < count; i++)
        {
            // Step 3: Calculate the i-th multiple and store it
            result[i] = value * (i + 1);
        }
        // Step 4: Return the filled array
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Normalize the rotation count
        if (data == null || data.Count == 0 || amount <= 0)
            return;

        int count = data.Count;
        amount = amount % count;
        if (amount == 0)
            return;

        // Step 2: Split the list
        List<int> tail = data.GetRange(count - amount, amount);
        List<int> head = data.GetRange(0, count - amount);

        // Step 3: Split into head and tail
        List<int> head = data.GetRange(0, count - amount);
        List<int> tail = data.GetRange(count - amount, amount);

        // Step 4: Clear the original list and reconstruct tail first, the head
        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
