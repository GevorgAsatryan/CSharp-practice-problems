namespace DoWhileAndWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Hi.How many liters of fuel would you want to pump? 1 liter is 500AMD");
            int total = int.Parse(Console.ReadLine());
            int liters = 0;
            int cost = 0;
            while (liters < total)
            {
                liters++;
                Console.WriteLine($"Pumped 1 liter.Total{liters}");
                cost += 500;
            }
            Console.WriteLine($"Total price {cost} AMD");
            //Task 2
            bool yesno = true;
            do
            {
                Console.WriteLine("Would you like to snooze the alarm?(Y/N)");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    Console.WriteLine("Snoozing for 5 more minutes.");
                }
                else
                {
                    yesno = false;
                }
            }
            while (yesno);

            //Task 3

            int attempts = 0;
            do
            {
                Console.WriteLine("Enter your PIN.");
                int pin = int.Parse(Console.ReadLine());
                if (pin == 1234)
                {
                    Console.WriteLine("Correct.");
                    attempts = 4;
                }
                else
                {
                    attempts++;
                    if (attempts == 3)
                    {
                        Console.WriteLine("Card Blocked.");
                    }
                }

            }
            while (attempts < 3);

            //Task 4

            int dice = 0;
            Console.WriteLine(dice);
            while (dice < 6)
            {
                Console.WriteLine("Dice Roll.");
                Console.ReadLine();
                Random ran = new Random();
                int roll = ran.Next(1, 7);
                Console.WriteLine(roll);
                dice = roll;

            }

            //Task 5

            Console.WriteLine("How many packages are left to diliver?");
            int packages = int.Parse(Console.ReadLine());
            while (packages > 0)
            {
                packages--;
                Console.WriteLine($"Remain {packages} packages");
            }

            //Task 6

            string store = null;
            bool yes = true;
            do
            {
                Console.WriteLine("Would you like to add more to the order?");
                string food = Console.ReadLine().ToLower();
                if (food == "no")
                {
                    yes = false;
                }
                else
                {
                    store += food + "/";
                }

            }
            while (yes);
            Console.WriteLine($"Your order list: {store}");

            //Task 7

            int price = 100;
            while (price <= 120)
            {
                Console.ReadLine();
                Random ran = new Random();
                int updown = ran.Next(-5, 6);
                price += updown;
                Console.WriteLine($"Price {price}");
            }

            //Task 8
            //Version 1

            Console.WriteLine("Enter height.");
            int n = int.Parse(Console.ReadLine());
            string asterisks = "*";
            while (n > 0)
            {
                Console.WriteLine(asterisks);
                n--;
                asterisks += "*";
            }

            //Version 2

            Console.WriteLine("Enter height.");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.WriteLine();

            //Task 9
            //Version 1

            int n = 4;
            while (n > 0)
            {
                string asterisks = new string('*', n);
                Console.WriteLine(asterisks);
                n--;
            }

            //Version 2

            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }

            //Task 10

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }

            //Task 11

            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            Console.WriteLine(new string('#', n));
            while (a > 2)
            {
                Console.WriteLine($"#{new string(' ', n - 2)}#");
                a--;
            }
            Console.WriteLine(new string('#', n));


            //Task 12

            Console.WriteLine("Enter pyramid height");
            int n = int.Parse(Console.ReadLine());
            string asterisks = "*";
            int space = n - 1;

            while (n > 0)
            {
                Console.WriteLine(new string(' ', space) + asterisks + new string(' ', space));
                asterisks = asterisks + "**";
                space -= 1;
                n--;
            }

            //Task 13

            Console.WriteLine("Enter height");
            int n = int.Parse(Console.ReadLine());
            int space = n - 1;
            string asterisks = "*";
            while (n > 0)
            {
                Console.WriteLine(new string(' ', space) + asterisks);
                space--;
                asterisks = asterisks + "*";
                n--;
            }

            //Task 14

            int s = int.Parse(Console.ReadLine());
            int a = s - 1;
            for (int i = 1; i <= s; i++)
            {
                Console.Write(new string('*', i));
                Console.WriteLine(new string('#', a));
                a--;
            }

        }
    }
}
