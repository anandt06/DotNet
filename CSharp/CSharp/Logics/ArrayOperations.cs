namespace CSharp.Logics
{
    internal class ArrayOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaximumElementOfArray());

            Console.WriteLine(GetMinimumElementOfArray());

            Console.WriteLine(FindRepeatingElementsOfAnArray());

            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6 };
            int[] orgArr = { 0, 1, 4, 8, 5, 9, 3, 1, 8 };
            int[] decSortedArray = { 9, 8, 7, 6, 5, 4 };

            Console.WriteLine(CheckIfArrayIsSorted(sortedArray));
            Console.WriteLine(CheckIfArrayIsSorted(orgArr));
            Console.WriteLine(CheckIfArrayIsSorted(decSortedArray));

            CheckIfArrayIsSortedUsingRecursion(orgArr, orgArr.Length);

            ReverseAnArray();

        }

        private static bool CheckIfArrayIsSortedUsingRecursion(int[] orgArr, int Length)
        {
            if (orgArr.Length == 0 || orgArr.Length == 1)
                return true;

            if (orgArr[Length - 1] < orgArr[Length - 2])
            {
                return false;
            }

            return CheckIfArrayIsSortedUsingRecursion(orgArr, Length - 1);
        }


        private static bool CheckIfArrayIsSorted(int[] orgArr)
        {
            bool isArraySorted = true;

            for (int i = 0; i < orgArr.Length - 1; i++)
            {
                if (orgArr[i] > orgArr[i + 1])
                {
                    isArraySorted = false;
                    break;
                }
                else
                {
                    isArraySorted = true;
                }
            }
            return isArraySorted;
        }

        private static void ReverseAnArray()
        {
            int[] orgArr = { 0, 1, 4, 8, 5, 9, 3, 1, 8 };
            //Stack<int> stack = new Stack<int>();

            int[] reverseArray = new int[orgArr.Length];
            int j = 0;
            for (int i = orgArr.Length - 1; i > 0; i--)
            {
                reverseArray[j] = orgArr[i];
                j++;
            }

            Console.WriteLine("Orginal Array: 0 1 4 8 5 9 3 1 8");
            foreach (var item in reverseArray)
            {
                Console.Write("{0} ", item);
            }

        }

        private static int FindRepeatingElementsOfAnArray()
        {
            int[] arr = { 0, 1, 4, 8, 5, 9, 3, 1, 8 };
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item]++;
                }
            }
            var values = map.Where(s => s.Value > 1).Select(q => q.Key).ToList();
            return values.Count;
        }

        private static int GetMaximumElementOfArray()
        {
            int[] arr = { 0, 1, 4, 8, 5, 9, 3 };
            int max = arr[0];
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    temp = arr[i];
                    arr[i] = max;
                    max = temp;
                }
            }
            return max;
        }

        private static int GetMinimumElementOfArray()
        {
            int[] arr = { 0, 1, 4, 8, 5, 9, 3 };
            int min = arr[0];
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    temp = arr[i];
                    arr[i] = min;
                    min = temp;
                }
            }
            return min;
        }
    }
}
