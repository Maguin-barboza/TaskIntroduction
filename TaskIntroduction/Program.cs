using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(() =>
            {
                for (int i=0; i<50; i++)
                {
                    Console.WriteLine("Task:" + i.ToString());
                    Thread.Sleep(500);
                }
            });

            task.Start();
            Console.ReadKey();
        }
    }
}
