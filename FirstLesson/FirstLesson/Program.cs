using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    internal class Program
    {
        static void Lesson1()
        {
            Console.WriteLine("Hello, World!");
            int some_mumber = 0;

            for (some_mumber = 0; some_mumber < 10; some_mumber++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine("");
            }
            int value = 19;
            Console.WriteLine(someFunction(value));
            Console.WriteLine("Today I learned how to create my project, some of data-types and cycles. I outputed matrix 10x10");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input lesson's number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case (1): Lesson1()
                    break;

                case (2): Console.WriteLine(2);
                    break;
                default: Console.WriteLine(3);
                    break;
            }
            

            Test test = new Test();
            
            Console.WriteLine(Test.test(60, "Math"));
            Console.Read();
        }
        static Type someFunction(int value)
        {
            return value.GetType();
        }
    }

    class Test
    {
        private int duration;
        private string discipline;
        public static string test(int duration, string discipline)
        {
            return $"This is {discipline} test with duration {duration} minutes";
        }
    }

     class Interview : Test
    {
        
    }

    class Exam
    {

    }

    class  FinalExam
    {
        
    }
}