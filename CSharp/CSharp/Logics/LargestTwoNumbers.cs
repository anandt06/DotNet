namespace CSharp.Logics
{
    internal class LargestTwoNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = { 25, 16, 38, 10, 35, 48, 20, 50 };
            int firstLargest = 0;
            int secondLargest = 0;
            if (arr[0] > arr[1])
            {
                firstLargest = arr[0];
                secondLargest = arr[1];
            }
            else
            {
                firstLargest = arr[1];
                secondLargest = arr[0];
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = arr[i];
                }
                else if (secondLargest < arr[i])
                {
                    secondLargest = arr[i];
                }

            }
        }
    }
}
