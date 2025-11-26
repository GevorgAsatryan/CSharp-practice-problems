namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 (factorial)
            int number = 1;
            while (number >= 0)
            {
               Console.WriteLine("Enter number to calculate factorial");
               number = int.Parse(Console.ReadLine());
               if (number < 0)
               {
                   Console.WriteLine("Factorials are only defined for non-negative integers.");
               }
               else
               {
                   try
                   {
                       checked
                       {
                           long factorial = 1;
                           for (int i = number; i > 1; i--)
                           {
                               factorial = i * factorial;
                           }
                           Console.WriteLine($"The factorial is {factorial}");
                       }
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine("The factorial of this number is too large.");
                   }

               }
            }


            // Task 2(Find the range where the sum of the numbers is the given number)
            
            int[] array = { 1, 2, 4, 5, 3, 7, 9, 10, 6, 11, 12, 14, 13, 15 };
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
               for (int j = i; j < array.Length; j++)
               {
                   sum += array[j];
                   if (sum == number)
                   {
                       Console.WriteLine($"[{i},{j}] (from {array[i]} to {array[j]})");
                       break;
                   }
                   else if (sum > number)
                   {
                       break;
                   }
               }
               sum = 0;
            }

        }
    }
    
   
    }
}

