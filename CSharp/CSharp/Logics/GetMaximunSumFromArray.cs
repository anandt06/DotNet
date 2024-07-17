namespace CSharp.Logics
{
    internal class GetMaximunSumFromArrayProgram
    {
        public static void Main(string[] args)
        {
            GetMaxSumFromArray();
        }
        private static int GetMaxSumFromArray()
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            List<int> subArray = new List<int>();
            int existingSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var sum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                    if (sum > existingSum)
                    {
                        existingSum = sum;
                        subArray.Add(arr[j]);
                    }
                    if (sum < 0)
                    {
                        sum = 0;
                        subArray = new List<int>();
                    }

                }
            }
            Console.WriteLine(existingSum);
            return existingSum;
        }
    }


}
