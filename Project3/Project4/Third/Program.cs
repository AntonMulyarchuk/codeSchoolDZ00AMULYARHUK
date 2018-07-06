using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {

          int a = 0;

            Console.WriteLine("Hello World!");
            Console.ReadLine ();
            Console.WriteLine("Введите число от 1 до 100:");
            a = int.Parse(Console.ReadLine());
             if(a >= 90)
             { Console.WriteLine("A, Отлично");
             Console.ReadLine();
             }
             else
             if(a >= 75)
             {Console.WriteLine("B, Хорошо");
              Console.ReadLine();
             }
             else
             if(a >= 65) 
             {Console.WriteLine("C, Удовлитворительно");
             Console.ReadLine();
             }
             else
             if(a >=60)
             {Console.WriteLine("D, засчитано");
             Console.ReadLine();
             }
             else
             if(a < 60)
             {Console.WriteLine("E,  Не засчитано");
             Console.ReadLine();
             }
             
             

        

            
        }
    }
}
