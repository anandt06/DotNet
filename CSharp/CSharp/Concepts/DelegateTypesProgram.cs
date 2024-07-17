namespace CSharp.Concepts
{
    internal class DelegateTypesProgram
    {
        static void Main(string[] args)
        {
            // Func delegate
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);

            // Action Delegate
            Action<int> printActionDel = ConsolePrint;
            printActionDel.Invoke(10);
            printActionDel(10);

            Action printAction = PrintHelloWorld;
            // Invoke the delegate
            printAction.Invoke();
            printAction();

            //Predicate delegate
            Predicate<string> isUpper = IsUpperCase;
            bool predicateResult = isUpper("hello world!!");
            Console.WriteLine(predicateResult);
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
