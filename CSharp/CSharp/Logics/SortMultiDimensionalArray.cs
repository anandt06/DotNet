namespace CSharp.Logics
{
    public class SortMultiDimensionalArray
    {
        static void Main(string[] args)
        {
            SortMultiDimensionalAray();
        }
        public static void SortMultiDimensionalAray()
        {
            int[,] arr = { { 11, 16, 18, 14 }, { 23, 24, 21, 22 }, { 34, 32, 31, 34 } };

            //if number of number of column count for each row is different

            //int totalElements = 0;
            //foreach (int element in arr)
            //{
            //    totalElements++;
            //}
            //int[] flatArr = new int[totalElements];

            int rows = arr.GetLength(0); // Since three subarrays are present
            int cols = arr.GetLength(1);

            // Flatten the 2D array to a 1D array
            int[] flatArr = new int[rows * cols]; // If number of cloumns for each row is equal
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArr[index++] = arr[i, j];
                }
            }


            SortArray(ref flatArr);

            // Display the sorted 2D array
            Console.WriteLine("Sorted 2D array:");
            for (int i = 0; i < flatArr.Length; i++)
            {
                Console.Write(flatArr[i] + " ");
            }
        }

        private static void SortArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

}
