public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //  Step-by-Step Breakdown
        // 1.	Understanding the Method Signature 
        //  The method MultiplesOf(double value, int count) should return an array of count multiples of value.
        //  2.	Create an Array of Doubles 
        //  Since the return type is double[], I’ll initialize an array of size count.
        //  3.	Fill the Array with Multiples 
        //  Use a loop to compute each multiple: value * i, where i ranges from 1 to count.
        //  4.	Return the Result 
        //  Once the array is filled, return it.
public static class Arrays
    {
        // This method returns an array of 'count' multiples of the given 'value'
        public static double[] MultiplesOf(double value, int count)
        {
            // Step 1: Create an array to hold the result
            double[] result = new double[count];

            // Step 2: Loop through from 1 to count
            for (int i = 0; i < count; i++)
            {
                // Step 3: Calculate the i-th multiple and store it
                result[i] = value * (i + 1);
            }

            // Step 4: Return the filled array
            return result;
        }
    }
    //        return []; // replace this return statement with your own
    //    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
//  Step-by-Step Logic
//  1.	Normalize the Rotation Count 
//  If rotateBy is greater than the list length, we use modulo to avoid unnecessary full rotations.
//  2.	Split the List 
//  We take the last rotateBy elements and move them to the front.
//  3.	Reconstruct the List 
//  Combine the tail and head to form the rotated list.
//  4.	Update the Original List 
//  Since the method modifies the list in-place, we clear and repopulate it.

public static class Arrays
{
    // Rotates the list to the right by 'rotateBy' positions
    public static void RotateListRight(List<int> numbers, int rotateBy)
    {
        // Step 1: Handle edge cases
        if (numbers == null || numbers.Count == 0 || rotateBy <= 0)
            return;

        int count = numbers.Count;

        // Step 2: Normalize the rotation count
        rotateBy = rotateBy % count;
        if (rotateBy == 0)
            return;

        // Step 3: Split the list into two parts
        List<int> tail = numbers.GetRange(count - rotateBy, rotateBy); // Last 'rotateBy' elements
        List<int> head = numbers.GetRange(0, count - rotateBy);        // Remaining elements

        // Step 4: Reconstruct the list
        numbers.Clear();
        numbers.AddRange(tail);
        numbers.AddRange(head);
    }
}
