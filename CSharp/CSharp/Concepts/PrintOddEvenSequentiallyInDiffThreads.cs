namespace CSharp.Concepts
{
    class PrintOddEvenSequentiallyInDiffThreads
    {
        // upto the limit numbers will be printed.
        const int numberLimit = 10;

        static object monitor = new object();

        static void Main(string[] args)
        {
            Thread oddThread = new Thread(Odd);
            Thread evenThread = new Thread(Even);

            evenThread.Start();

            Thread.Sleep(100);

            oddThread.Start();

            oddThread.Join();
            evenThread.Join();
            Console.WriteLine("\nPrinting done!!!");

            Console.ReadLine();
        }

        static void Odd()
        {
            try
            {
                Monitor.Enter(monitor);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    Console.Write(" " + i);
                    Monitor.Pulse(monitor);
                    bool isLast = i == numberLimit - 1;
                    if (!isLast)
                        Monitor.Wait(monitor);
                }
            }
            finally
            {
                Monitor.Exit(monitor);
            }
        }

        static void Even()
        {
            try
            {
                Monitor.Enter(monitor);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    Console.Write(" " + i);
                    Monitor.Pulse(monitor);
                    bool isLast = i == numberLimit;
                    if (!isLast)
                        Monitor.Wait(monitor);
                }
            }
            finally
            {
                Monitor.Exit(monitor);
            }

        }
    }
}

//Monitor.Enter(object): Acquires an exclusive lock on the specified object.
//Monitor.Exit(object):  Releases the lock on the specified object.
//Monitor.Wait(object):  Releases the lock on an object and waits until it reacquires the lock.
//Monitor.Pulse(object): Notifies a waiting thread that a condition has changed.