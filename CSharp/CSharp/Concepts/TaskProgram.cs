namespace CSharp.Concepts
{
    internal class TaskProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");

            //Action actionDelegate = new Action(TaskPgm.PrintCounter);
            //Task task1 = new Task(actionDelegate);
            //task1.Start();


            //You can directly pass the PrintCounter method as its signature is same as Action delegate
            //Task task1 = new Task(PrintCounter);
            //task1.Start();


            //Task task1 = Task.Factory.StartNew(TaskPgm.PrintCounter);

            //Task task1 = Task.Run();

            //Task task1 = Task.Run(() =>
            //{
            //    TaskPgm.PrintCounter();
            //});

            Task task = Task.Run(() => { TaskPgm.RetunValue(); }).ContinueWith((i) => { TaskPgm.PrintCounter(); });




            Task a = Task.Run(() => { return "Anand"; }).ContinueWith((a) => { TaskPgm.PrintCounter(); });
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadKey();
        }
    }

    public class TaskPgm
    {
        public static void PrintCounter()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"count value: {count}");
            }
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
        }

        public static int RetunValue()
        {
            Console.WriteLine("Value Printed = {0}", 1);
            return 15;
        }

    }
}
