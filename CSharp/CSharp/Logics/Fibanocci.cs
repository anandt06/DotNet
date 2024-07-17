namespace CSharp.Logics
{
    internal class Fibanocci
    {
        static void Main(string[] args)
        {
            int number = 5;
            int n1 = 0;
            int n2 = 1;
            int n3;
            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
