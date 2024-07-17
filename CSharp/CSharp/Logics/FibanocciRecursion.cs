namespace CSharp.Logics
{
    internal class FibanocciRecursion
    {
        void Main(string[] args)
        {
            RecursionFibbonacci(5);
        }

        static int RecursionFibbonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return RecursionFibbonacci(n - 1) + RecursionFibbonacci(n - 2);
            }
        }
    }
}
