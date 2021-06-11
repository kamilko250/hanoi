using System.Collections.Generic;
using System.IO;

namespace hanoi
{

    class Program
    {
        static void Hanoi(int n, List<int> left, List<int> middle, List<int> right, StreamWriter sw)
        {
            if (n > 0)
            {

                Hanoi(n - 1, left, right, middle, sw);
                
                
                right.Add(left[^1]);
                left.Remove(left[^1]);

                WriteState(left, middle, right, sw);
                
                Hanoi(n - 1, middle, left, right, sw);
                
            }
        }
        static List<int> Init(int c)
        {
            List<int> init = new();
            for (int i = c; i > 0; i--)
            {
                init.Add(i);
            }
            return init;
        }
        static void Main(string[] args)
        {
            const int value = 5;
            List<int> right = Init(value);
            List<int> middle = new();
            List<int> left = new();
            StreamWriter sw = new("test.txt");
            WriteState(left, middle, right, sw);
            Hanoi(value, right, middle, left, sw);
            sw.Close();
        }
        static void WriteState(List<int> a, List<int> b, List<int> c, StreamWriter sw)
        {
            
            sw.Write("~");
            foreach (var e in a)
                sw.Write(e + " ");
            sw.WriteLine();
            sw.Write("~");
            foreach (var e in b)
                sw.Write(e + " ");
            sw.WriteLine();
            sw.Write("~");
            foreach (var e in c)
                sw.Write(e + " ");
            sw.WriteLine();
            sw.WriteLine();

        }
    }
}
