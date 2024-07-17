namespace CSharp.Logics
{
    internal class GenerateCombinationsProgram
    {
        static void Main(string[] args)
        {
            string input = "123";
            List<string> combinations = new List<string>();
            GenerateCombinations(input, "", 0, combinations);
            //GenerateCombinations(input);
            Console.WriteLine("Combinations of the string " + input + ":");
            foreach (string combination in combinations)
            {
                Console.WriteLine(combination);
            }
        }

        static void GenerateCombinations(string input, string current, int index, List<string> combinations)
        {
            if (index == input.Length)
            {
                if (current.Length > 0) // To exclude the empty combination
                {
                    combinations.Add(current);
                }
                return;
            }

            // Include the current character in the combination
            GenerateCombinations(input, current + input[index], index + 1, combinations);

            // Exclude the current character from the combination
            GenerateCombinations(input, current, index + 1, combinations);
        }

        //static List<string> GenerateCombinations(string input)
        //{
        //    List<string> combinations = new List<string>();
        //    int n = input.Length;
        //    int totalCombinations =(int)Math.Pow(2, n);// (1 << n); // 2^n combinations

        //    for (int i = 1; i < totalCombinations; i++) // Start from 1 to exclude the empty combination
        //    {
        //        string combination = "";
        //        for (int j = 0; j < n; j++)
        //        {
        //            // Check if the j-th bit is set in i
        //            if ((i & (1 << j)) != 0)
        //            {
        //                combination += input[j];
        //            }
        //        }
        //        combinations.Add(combination);
        //    }

        //    return combinations;
        //}
    }
}