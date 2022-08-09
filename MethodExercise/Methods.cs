using System;
using System.Collections.Generic;
using System.Text;

namespace MethodExercise
{
    internal class Methods
    {

        public static void Add()
        {
            Console.WriteLine("Enter in a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in a second number");
            int num2 = int.Parse(Console.ReadLine());
            var answer = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {answer}");





        }
        public static int Multiply(int x, int y)
        {
            int answer = x * y;
            return answer;
        }

        public static int Subtract(int x, int y)
        {
            int answer = x - y;
            return answer;

            
        
        
        }
        public static double Divide(int x, int y)
        {
            return x / y;


        }
        public static double Mod(int x, int y)
        {
            
            return x % y;
        
        
        }

        
        


    }

   







}

