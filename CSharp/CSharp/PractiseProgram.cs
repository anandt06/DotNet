using System;

namespace CSharp
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bow Bow");
        }
    }
    public class PractiseProgram
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.MakeSound();

            int[] nums = { 2, 7, 11, 15 };
            var nusm = GetIndexOfTargetSum1(nums, 9);

            int[,] multiDimentionalArray = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            SumOfUpperAndLowerTriangleInMultidimensionalArray(multiDimentionalArray);
        }

        //LEETCODE : Two Sum
        //Complexity : O(n^2)
        public static int[] GetIndexOfTargetSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };

                    }
                }
            }
            return null;
        }


        public static int[] GetIndexOfTargetSum1(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }

        //Method 1 : here if is used and i and j runs till row countCount and colCount
        public static void SumOfUpperAndLowerTriangleInMultidimensionalArray(int[,] nums)
        {
            int rowCount = nums.GetLength(0);

            int columnCount = nums.GetLength(1);

            //Upper triangle
            int upperSum = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (i <= j)
                    {
                        upperSum = upperSum + nums[i, j];
                    }
                }
            }
            //Lower triangle
            int lowerSum = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (i >= j)
                    {
                        lowerSum = lowerSum + nums[i, j];
                    }
                }
            }
        }
    }

}