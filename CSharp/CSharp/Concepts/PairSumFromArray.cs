namespace CSharp.Concepts
{
    class PairSumFromArray
    {
        static void Main(string[] args)
        {
            int[] arr =  { 1, 2, 3, 4, 5, 6, 4 };
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                foreach (var item1 in arr)
                {
                    if(item+item1== 8)
                    {
                        if (!keyValuePairs.ContainsKey(item))
                        {
                            keyValuePairs.Add(item, item1);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
