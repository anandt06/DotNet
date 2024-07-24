namespace CSharp.Logics
{
    public class Searching
    {
        static void Main(string[] args)
        {
            LinearSearch(6);
        }

        private static void LinearSearch(int value)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine("value found at {0} position", i);
                    break;
                }
            }
            if (i == arr.Length)
            {
                Console.WriteLine("Element not found");
            }
        }
    }

}
