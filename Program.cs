using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist number");
           int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int i; int y;int x = 0;
            if (num1 >= 1 && num2 > num1)
            {
                for (i = 1; i < num2; i++)
                {
                    for (y = 1; y < num2; y++)
                    {
                        if (i % y == 0)
                        {
                            x++;

                        }
                                                   
                    }
                    if (x == 2)
                    
                    

                    
                    {
                        Console.WriteLine(i);
                    }
                    x = 0;
                    
            }
            }
            else
                Console.WriteLine("error");
            Console.ReadKey();
            


        }    
    }
}
