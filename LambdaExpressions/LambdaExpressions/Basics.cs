using System;

namespace LambdaExpressions
{
    public class Basics
    {
        public void Example()
        {
            //args => expression .. Syntax of lamda exp

            // () =>...         if we dont need any arguements
            // x =>....         if we have one argument we can use arguement itself without using paranthesis
            // (x,y,z) =>..     if we have multiple arguements then we use paranthesis

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
            // Console.WriteLine(Square(5));

            //lambda expressions have access to the variables defined inside the method :
            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);
            Console.WriteLine(result);


            /*
             without lambda exp i.e. normal method
            static int Square(int number)
            {
                return number * number;
            }
            */
        }

    }
}
