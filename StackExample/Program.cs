using System;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эмуляция Йоды!");
            
            var yoda = new Stack<string>();
            
            yoda.Push("меня");
            yoda.Push("зовут");
            yoda.Push("Йода");
            
            LetsIterate(yoda);
            
        }

        static void LetsIterate<T>(Stack<T> stack)
        {
            foreach (var element in stack)
            {
                Print(element);
            }
        }

        static void Print<T>(T element)
        {
            Console.WriteLine(element);
        }
    }
}