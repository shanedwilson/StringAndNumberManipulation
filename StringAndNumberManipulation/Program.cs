using System;

namespace StringAndNumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a comma seperated number string.");
            var userInput = Console.ReadLine().Split(',');
            Console.WriteLine("Would you like to multiply or square your numbers?");
            var multiply = Console.ReadLine();
            int product = 1;
            var answer = "";
            for (int i = 0; i < userInput.Length; i++)
            { 
                if (multiply == "multiply")
                {
                    product = product * Convert.ToInt32(userInput[i]);
                    answer = product.ToString();
                }
                if (multiply == "square")
                {
                    product = Convert.ToInt32(userInput[i]) * Convert.ToInt32(userInput[i]);

                    if (i != userInput.Length -1)
                    {
                        answer += product.ToString() + ", ";
                    }
                    else
                    {
                        answer += product.ToString();
                    }
                }
            }
            Console.Write("Your answer is: " + answer);
            Console.ReadKey();
        }
    }
}
