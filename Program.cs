using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CircularQueue Q = new CircularQueue(10);
            while (true)
            {
                int a = 0;
                Console.WriteLine("Enter Number to perform specific Operation");
                Console.WriteLine("Enter 1 to add a number in Queue");
                Console.WriteLine("Enter 2 to delete a number from Queue");
                Console.WriteLine("Enter 3 to display the elements of Queue");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int b = 0;
                        Console.WriteLine("Enter Number to add in Circular Queue");
                        b = Convert.ToInt32(Console.ReadLine());
                        Q.Enqueue(b);
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 2:
                        Q.Dequeue();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Elements in CircularQueue are: ");
                        Q.display();
                        Console.WriteLine("-------------------------------------");
                        break;
                    default:
                        Console.WriteLine("You can Try Again :)");
                        break;
                }
            }
          
        }
    }
}
