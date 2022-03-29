using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    internal class CircularQueue
    {
        private int [] arr;
        private int front;
        private int rear;
        private int last;
        private int count;

        public CircularQueue(int len)
        {
            arr = new int[len];
            front = 0;
            rear = -1;
            last = len;
            count = 0;
        }

        public void Enqueue(int num)
        {
            if (count == last)
            {
                Console.WriteLine("Queue is Completely Filled");
                return;
            }
            else
            {
                rear = (rear + 1) % last;
                arr[rear] = num;

                count++;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Current Length of Circular Queue is: " + count);
                
            }
        }

        public void Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty having no any Element");
            }
            else
            {
                Console.WriteLine("Deleted element from the Queue is: " + arr[front]);

                front = (front + 1) % last;

                count--;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Current Length of Circular Queue is: " + count);
                Console.WriteLine("---------------------------------------------");
            }
        }

        public void display()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue have no Element - It is Empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine(arr[i]);

                    i = (i + 1) % last;
                    j++;

                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Current Size of CircularQueue is: " + count);
                
            }
        }
    }
}
