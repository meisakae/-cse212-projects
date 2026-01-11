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
        //step 1 creat an array to hold the multiples
        double[] multiples = new double[length];
        //step 2 loop from 0 to leght -1
        for (int i = 0; i < length; i++)
        {
            //step 3 calculate the multiples
            multiples[i] = number * (i + 1);
        }
        //step 4 return the array

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
        //step 1 get size
        int count = data.Count;
        //step 2 adjust amout
        amount %= count;
        //step 3 get the last amout
        List<int> endPart = data.GetRange(count - amount, amount);
        //step 4 get the first amout
        List<int> startPart = data.GetRange(0, count - amount);
        //step 5 clear the original list
        data.Clear();
        //step 6 add 
        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}
