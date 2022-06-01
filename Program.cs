//Beni Yaratan Elbet Yolumu Gösterir .Şuara 78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1;
            float number2;
            float sum;

            Console.WriteLine("Please enter first number :");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number :");
            number2 = float.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum of two number :"+" "+ sum);

            Console.Read();
        
        }
    }
}
