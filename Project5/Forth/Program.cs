using System;

namespace Forth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 0, num2 = 0, num3 = 0;
        

            Console.WriteLine("введите первое число:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("введите второе число:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("введите третье число:");
            num3 = int.Parse(Console.ReadLine());
            int highest = ((num1 > num2 ? num1: num2) > num3 ? 
                (num1 > num2 ?  num1 : num2)  : num3) ;
             Console.WriteLine(" highest is {0} ", highest);
            Console.ReadLine();   
      }
    }
}
