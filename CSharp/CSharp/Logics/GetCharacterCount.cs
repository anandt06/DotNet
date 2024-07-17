namespace CSharp.Logics
{
    internal class GetCharacterCountProgram
    {
        static void Main(string[] args)
        {
            var characterCount = GetCharacterCount("Anand");
        }
        public static IDictionary<string, int> GetCharacterCount(string s)
        {
            s = string.Concat(s.Where(c => !char.IsWhiteSpace(c)));
            IDictionary<string, int> characterDict = new Dictionary<string, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!characterDict.ContainsKey(s[i].ToString()))
                {
                    characterDict.Add(s[i].ToString(), 1);
                }
                else
                {
                    characterDict.TryGetValue(s[i].ToString(), out int count);
                    count++;
                    characterDict[s[i].ToString()] = count;
                }
            }
            return characterDict;
        }
    }
}
