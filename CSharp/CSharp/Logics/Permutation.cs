namespace CSharp.Logics
{
    public class Permutation
    {
        static void Main(string[] args)
        {
            string str = "ABC";
            int n = str.Length;
            Permute(str, 0, n - 1);
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="si"> start index </param>
        /// <param name="ei"> ending index </param>
        private static void Permute(string str,
                                 int si, int ei)
        {
            if (si == ei)
                Console.WriteLine(str);
            else
            {
                for (int i = si; i <= ei; i++)
                {
                    str = Swap(str, si, i);
                    Permute(str, si + 1, ei);
                    str = Swap(str, si, i);
                }
            }
        }

        /**
        * Swap Characters at position
        * @param a string value
        * @param i position 1
        * @param j position 2
        * @return swapped string
        */
        public static string Swap(string a,
                                  int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

    }
}
