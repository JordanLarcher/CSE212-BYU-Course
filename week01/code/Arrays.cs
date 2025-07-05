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
        // first I have to create an array of the specified length
        double[] result = new double[length];


        // Then I will loop over the length of the array 
        // and fill it with the multiples of a given number
        for (int i = 0; i < length; i++)
        {
            // In the first iteration // I will multiply the number by 1, then by 2, and so on
            // until I reach the length of the array 
            // so each time it will be multiplied by ( i + 1)
            result[i] = number * (i + 1);
        }
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
        // First I will check if the amount is greater than 0 and less than or equal to the count of the
        // data list, if not I will throw an exception
        if (amount < 1 || amount > data.Count)
        {
            throw new ArgumentException("Amount must be between 1 and the count of the data list, inclusive.");

        }
        // Then I will create a temporary list to hold the last amount of elements
        List<int> tempArrayList = data.GetRange(data.Count - amount, amount);
        // I will remove the last amount of elements from the data list 
        data.RemoveRange(data.Count - amount, amount);
        // Then I need to insert the temporary list at the beginning of the data list by using InsertRange method
        data.InsertRange(0, tempArrayList);
        
    }
}
