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
            Console.WriteLine("Enter your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("Enter an animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("Enter a band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{name} is a Manchester City fan \n" +
                $"{name}'s favoite color is {color} because of his favorite team \n" +
                $"{animal}'s are a representation of his spirit \n" +
                $"{band} hits his soul \n" +
                $"{name} loves his children and is doing coding for a better life");
           




            var sum1 = Methods.Add(20, 50);
            Console.WriteLine(sum1);
            var sum2 = Methods.Subtract(100, 30);
            Console.WriteLine(sum2);
            var sum3 = Methods.Multiply(200, 10);
            Console.WriteLine(sum3);
           
           










        }
    }
}
