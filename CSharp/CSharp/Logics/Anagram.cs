namespace CSharp.Logics
{
    /// <summary>
    /// An anagram is a word or phrase formed by rearranging the letters of another word or phrase, using all the original letters
    /// </summary>
    internal static class Anagram
    {
        static void Main(string[] args)
        {

            string str1 = "listen";
            string str2 = "silent";

            if (AreAnagrams(str1, str2))
            {
                Console.WriteLine($"\"{str1}\" and \"{str2}\" are anagrams.");
            }
            else
            {
                Console.WriteLine($"\"{str1}\" and \"{str2}\" are not anagrams.");
            }
        }
        static bool AreAnagrams(string str1, string str2)
        {
            str1 = str1.Replace(" ", "").ToLower();
            str2 = str2.Replace(" ", "").ToLower();

            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            return new string(charArray1) == new string(charArray2);
        }

    }

    
}
