namespace CSharp.Concepts
{
    internal class DelegateProgram
    {
        public delegate void AddNumberDelegate(int a, int b);

        public delegate double AddSoubleNumberDelegate(double a, double b);

        public delegate bool CheckIfSumIsGreaterThan10Delegate(double a, double b);

        static void Main(string[] args)
        {
            AddNumberDelegate addNumber = new AddNumberDelegate(Delegate.AddNumber);
            addNumber.Invoke(10, 29);

            Action<int, int> actionDelegate = Delegate.AddNumber;
            actionDelegate.Invoke(10, 28);

            Func<double, double, double> funcDelegate = Delegate.AddDoubleNumber;
            var result = funcDelegate.Invoke(10, 18);

            Predicate<int> predicate = Delegate.ValidateSumIsGreatherThan10;
            var result1 = predicate.Invoke(10);

        }
    }

    public class Delegate
    {
        public static void AddNumber(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static double AddDoubleNumber(double a, double b)
        {
            return a + b;
        }

        public static bool ValidateSumIsGreatherThan10(int a)
        {
            if (a > 10)
            {
                return true;
            }
            return false;
        }
    }
}
