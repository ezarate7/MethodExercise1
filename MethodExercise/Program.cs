using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you"); 
                Console.WriteLine(name);
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine("Thats awesome you like");
            Console.WriteLine(band);


            var sum1 = Methods.Add(20, 50);
            Console.WriteLine(sum1);
            var sum2 = Methods.Subtract(100, 30);
            Console.WriteLine(sum2);
            var sum3 = Methods.Multiply(200, 10);
            Console.WriteLine(sum3);
           

            







        }
    }
}
