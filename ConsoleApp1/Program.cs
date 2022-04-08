using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "12359";
            var str2 = "6321";            
            Console.WriteLine(MathHelper.Sum(str1, str2));

            Console.ReadKey();
        }

        
    }
}
