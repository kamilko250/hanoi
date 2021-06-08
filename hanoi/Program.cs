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
        static void init(int c, List<int> init)
        {
            for (int i = c; i > 0; i--)
            {
                init.Add(i);
            }
        }
        static void Main(string[] args)
        {
            const int value = 5;
            List<int> right = new();
            List<int> middle = new();
            List<int> left = new();
            init(value, right);
            hanoi(value, right, middle, left);
        }
    }
}
