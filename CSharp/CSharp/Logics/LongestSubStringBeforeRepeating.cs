namespace CSharp.Logics
{
    internal class LongestSubStringBeforeRepeating
    {
        static void Main(string[] args)
        {

            var longestSubString = GetLongestSubStringBeforeRepeting("anand");
        }


        public static string GetLongestSubStringBeforeRepeting(string s)
        {
            s = string.Concat(s.Where(c => !char.IsWhiteSpace(c)));
            IDictionary<string, int> characterDict = new Dictionary<string, int>();
            string longestSubString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!characterDict.ContainsKey(s[i].ToString()))
                {
                    characterDict.Add(s[i].ToString(), 1);
                    longestSubString = longestSubString + s[i].ToString();

                }
                else
                {
                    return longestSubString; // or can use break
                }
            }
            return longestSubString;
        }
    }
}
