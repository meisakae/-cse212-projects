public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        //step 1 creat an array to hold the multiples of the store
        double[] multiples = new double[length];
        //step 2 loop from 0 to leght -1
        for (int i = 0; i < length; i++)
        {
            //step 3 calculate the multiples of the number
            multiples[i] = number * (i + 1);
        }
        //step 4 return the array

        return multiples; // replace this return statement with your own
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        //step 1 get size for the list
        int count = data.Count;
        //step 2 adjust amout
        amount %= count;
        //step 3 get the last amout
        List<int> endPart = data.GetRange(count - amount, amount);
        //step 4 get the first amout
        List<int> startPart = data.GetRange(0, count - amount);
        //step 5 clear the original list
        data.Clear();
        //step 6 add the list
        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}

