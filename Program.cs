using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceTreeTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваш ответ: ");

            Console.WriteLine(Addition(a, b));
            Console.ReadLine();           
        }

        static int Addition(int a, int b)
        {
            int result = a + b;
            
            return result;
        }
    }
}
