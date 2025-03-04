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

        // 1.- Create an array of size 'length'
        double[] multiples = new double[length];

        // 2.- Initialize the index of the 'multiples' array to 0
        int multipleIndex = 0;
        // 3.- Loop 'length' times (the number of multiples we need) :
            // Initialize the loop at 1, because we want the first multiple of any number
            // Finish the loop at 'length + 1' since we started the loop at 1
        for (int i = 1; i < length + 1; i++)
        {
            // Add the multiple (number * i) to the 'multiples' array 
            multiples[multipleIndex] = number * i;
            // Increment the 'multipleIndex' variable by 1
            multipleIndex++;
        }

        // Return the 'multiples' array
        return multiples; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1.- Create a temporary list to store the elements that will be rotated
        List<int> rotateData = new List<int>();

        //  2.- Extract the last 'amount' elements from the original list
        rotateData = data.GetRange(data.Count - amount, amount);

        //  3.- Remove the extracted elements from the original list
        data.RemoveRange(data.Count - amount, amount);
        
        //  4.- Insert the rotated elements at the beginning of the original list
        data.InsertRange(0, rotateData);
    }
}
