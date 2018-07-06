using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 0, num2 = 0, num3 = 0;
        

            Console.WriteLine("first side of the triangle:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("second side of the triangle:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("third side of the triangle:");
            num3 = int.Parse(Console.ReadLine());


            int lowest = ((num1 < num2 ? num1: num2) < num3 ? 
                (num1 < num2 ? num1 : num2) : num3);
            int highest = ((num1 > num2 ? num1: num2) > num3 ? 
                (num1 > num2 ?  num1 : num2)  : num3) ;
            Console.WriteLine(" lowest is {0} ", lowest);
            Console.WriteLine(" highest is {0} ", highest);
            Console.ReadLine();
            Console.WriteLine("triangle is real:");
            Console.ReadLine();
            if (highest < lowest + num2)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
            else
            { 
              Console.WriteLine("false");
              Console.ReadLine();
            }




        

        }
    }
}
