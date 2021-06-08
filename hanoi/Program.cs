using System;
using System.Collections.Generic;

namespace hanoi
{
    
    class Program
    {
        static void hanoi(int n, List<int> left, List<int> middle, List<int> right) 
        {
            if (n > 0)
            { 
                hanoi(n-1, left, right, middle);
                
                right.Add(left[left.Count - 1]);
                left.Remove(left[left.Count - 1]);
                hanoi(n-1, middle, left, right);
            }
        
        }
        static void Main(string[] args)
        {
            List<int> right = new();
            List<int> middle = new();
            List<int> left = new();
            for (int i = 3; i > 0; i--)
            {
                right.Add(i);
            }
            hanoi(3, right, middle, left);



            Console.WriteLine("Hello World!");
        }
    }
}
