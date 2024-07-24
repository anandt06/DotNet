namespace CSharp.Logics
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int limit = 5;
            int factorial = 0;
            for (int i = 1; i <= limit; i++)
            {
                factorial = factorial * i;
            }
        }
    }
}
