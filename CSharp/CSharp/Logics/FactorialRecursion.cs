namespace CSharp.Logics
{
    internal class FactorialRecursion
    {
        static void Main(string[] args)
        {
            RecursionFactorialMethod(2);
        }

        static int RecursionFactorialMethod(int n)
        {
            //base case
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * RecursionFactorialMethod(n - 1);
            }
        }
    }
}
