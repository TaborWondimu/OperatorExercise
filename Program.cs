using System;
namespace OperatorExercise
{
    public class program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine ("Simple Additon code using operators");
            int a = 6;
            int sum = a += 5;
            Console.WriteLine($" our result is {sum}");

            Console.WriteLine("Simble Subtraction code using operator");
            int subtraction = a -= 5;
            Console.WriteLine($" our result is {subtraction}");

            Console.WriteLine("Simple Multiplicatoin Code using operator");
            int product = a *= 5;
            Console.WriteLine($" our result is {product}");

            Console.WriteLine("This is the Divison Code and Remainder");
             int num1 = 17;
             int num2 = 4;
             int quotient = num1 / num2;
             int remainder = num1 % num2;
            if (num1 == 17 && num2 == 4)
            {
                Console.WriteLine($" 17/4 is  {quotient} and remainder is  {remainder}");
            }
            // this allpws user to enter any number to calculate area
            Console.WriteLine("Please enter the radius of the circle");
            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);
            var area = AreaOfCircle(realRadius);

            Console.WriteLine($"The area of a circle with radius of {realRadius} is {area}");   

        }
        public static double AreaOfCircle(double radius)
        {
          return  Math.PI * radius * radius;
             
        }
    }
}

