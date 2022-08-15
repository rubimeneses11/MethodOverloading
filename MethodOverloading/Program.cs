using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.2m, 2.1m));
            Console.WriteLine(Add(0, 1, true));
        }

        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //create an overload of the Add method to account for being able to add two decimals together
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        //create another overload of the Add method that returns a string and accepts 3 parameters
        //: 2 integers and 1 boolean
        public static string Add(int a, int b, bool isTrue)
        {
            var answer = "string";
            if (isTrue)
            {
                var sum = a + b;
                {
                    if (sum == 1)
                    {
                        answer = $"{sum} dollar.";
                    }
                    else
                    {
                        answer = $"{sum} dollars.";
                    }
                }
            }

            return answer;
        }
    }

}

