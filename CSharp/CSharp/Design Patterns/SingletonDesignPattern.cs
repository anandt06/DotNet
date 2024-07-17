namespace CSharp
{
    class Singleton1
    {
        private Singleton1()
        {

        }

        private static readonly object lock1 = new object();

        private static Singleton1? instance;

        public static Singleton1 Instance
        {
            get
            {
                lock (lock1)
                {
                    if (instance == null)
                    {
                        instance = new Singleton1();
                    }
                    return instance;
                }

            }
        }
    }
}