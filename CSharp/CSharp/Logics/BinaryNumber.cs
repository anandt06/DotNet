namespace CSharp.Logics
{
    class BinaryNumber
    {
        static void Main(string[] args)
        {
            var binaryNumber = GetBinaryNumber(11);
            Console.WriteLine(binaryNumber);
        }
        public static string GetBinaryNumber(int number)
        {
            string binaryNumber = "";
            int remainder = 0;
            while (number != 0)
            {
                if (number == 1)
                {
                    remainder = 1;
                    number = 0;
                }

                else
                {
                    number = number / 2;
                    remainder = number % 2;
                }
                binaryNumber += remainder.ToString();

            }
            return binaryNumber;
        }
    }
}
