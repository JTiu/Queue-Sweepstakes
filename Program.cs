using System;
using System.Collections;

namespace CollectionsApplication
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("Sweeper1,");
            q.Enqueue("Sweeper2,");
            q.Enqueue("Sweeper3,");
            q.Enqueue("Sweeper4,");

            Console.WriteLine("Current queue: ");
            foreach (string c in q) Console.Write(c + " ");

            Console.WriteLine("Add two sweepers");
            q.Enqueue("Sweeper5,");
            q.Enqueue("Sweeper6,");
            Console.WriteLine("Current queue: ");
            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Removing  values ");
            string ch = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.ReadKey();

            
        }
        
    }
}
