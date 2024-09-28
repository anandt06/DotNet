using System.Text;

namespace CSharp.Logics
{
    internal class ReverseStringProgram
    {
        static void Main(string[] args)
        {
            var reverseValue = ReverseString();

            IsPalindrome("MALATALAM");

            ReverseNumber(123);

        }

        private static void ReverseNumber(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                var remainder = number % 10;
                number = number / 10;
                reverse = reverse * 10 + remainder;
            }
            Console.WriteLine(reverse);
        }

        static string ReverseString()
        {
            string rev = "";
            string name = "Anand";
            for (int i = name.Length-1; i >= 0; i--)
            {
                rev += name[i];
            }
            return rev;
        }
        private static string ReverseString(string s)
        {
            string s1 = "";
            StringBuilder reversed = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }
            return reversed.ToString();
        }

        private static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;
        }


    }
}
