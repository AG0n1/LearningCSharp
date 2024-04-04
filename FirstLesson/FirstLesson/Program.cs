using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int some_mumber = 0;

            for (some_mumber = 0; some_mumber < 10; some_mumber++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine(");
            }
            int value = 19;
            Console.WriteLine(someFunction(value));
            Console.WriteLine("Today I learned how to create my project, some of data-types and cycles. I outputed matrix 10x10");
        }

        static Type someFunction(int value)
        {
            return value.GetType();
        }
    }
}
