
namespace CSharp.Logics
{
    internal class SquareRoot
    {
        public static void Main() 
        {

            int number = 25;
            var squareRoot = GetSquareRootOfNumber(number);

        }

        //we use binary search algo to find the square root
        private static object GetSquareRootOfNumber(int number)
        {
            int low = 1;
            int high = number;

            int result = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if(mid*mid == number)
                {
                    return number;
                }
                else if(mid*mid > number)
                {
                        high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                    result = mid;
                }

            }
            return result;
        }
    }
}
