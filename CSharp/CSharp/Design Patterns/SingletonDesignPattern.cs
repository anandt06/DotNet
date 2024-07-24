namespace CSharp.DesignPatterns
{
    class Singleton
    {
        private Singleton()
        {

        }

        private static readonly object lock1 = new object();

        private static Singleton? instance;

        public static Singleton Instance
        {
            get
            {
                lock (lock1)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }

            }
        }
    }
}