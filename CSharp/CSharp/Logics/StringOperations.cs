namespace CSharp.Logics
{
    internal class StringOperations
    {
        static void Main(string[] args)
        {
            // ChangeStringToUpper();

            //System.Console.WriteLine(CountNuumberOfVowels("abcde"));

            ReverseString("anand");
        }

        private static void ChangeStringToUpper()
        {
            string str = "Anand";
            string s = "";
            foreach (int character in str)
            {
                if (character >= 97 && character <= 122)
                {
                    s += (char)(character - 32);
                }
                else
                    if (character >= 65 && character <= 90)
                {
                    s = s + (char)character;
                }
            }
            System.Console.WriteLine(s);
        }

        static int CountNuumberOfVowels(string word)
        {
            int vowelCount = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char letter in word)
            {
                foreach (var vowel in vowels)   // can also use if
                {
                    if (letter == vowel)
                    {
                        vowelCount++;
                    }
                }
            }
            return vowelCount;

        }

        static string ReverseString(string word)
        {
            string reversedString = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                reversedString = reversedString + word[i];
            }
            return reversedString;
        }

    }
}
