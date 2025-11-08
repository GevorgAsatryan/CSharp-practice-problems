namespace ConsoleBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.WriteLine("Hi.What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,{name}! Welcome to your first C# program.");

            //Task 2
            Console.WriteLine("Enter two numbers.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = a - b;
            int m = a * b;
            int d = a / b;
            Console.WriteLine($"Your numbers are {a} and {b}.");
            Console.WriteLine($"{a}-{b}={s}");
            Console.WriteLine($"{a}*{b}={m}");
            Console.WriteLine($"{a}/{b}={d}");

            //Task 3
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            string number = Console.ReadLine();
            Console.WriteLine($"You love {color},{food}, and your lucky numver is {number}");

            //Task 4
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Where are you from?");
            string country = Console.ReadLine();
            Console.WriteLine($"Your name is {firstname} {lastname},you are {age} years old and you live in {country}");

            //Task 5
            Console.WriteLine("Enter a number of hours to convert it to minutes.");
            int hours = int.Parse(Console.ReadLine());
            int minutes = hours * 60;
            Console.WriteLine($"That's {minutes} minutes.");

        }
    }
}
