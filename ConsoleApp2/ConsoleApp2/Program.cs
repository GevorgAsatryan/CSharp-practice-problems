using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ////Task 1
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < 3; i++)
            //{
            //    result.Clear();
            //    Console.WriteLine("Enter vehicle brand");
            //    string brand = Console.ReadLine();
            //    Console.WriteLine("Enter model");
            //    string model = Console.ReadLine();
            //    Console.WriteLine("Enter year");
            //    int year = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter engine capacity");
            //    int enginecapacity = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter owner name");
            //    string name = Console.ReadLine();
            //    string vehicle = $"Brand {brand}, model {model}, year {year}, engine capacity {enginecapacity}, name {name}";
            //    if ((year < 1980 || year > 2025) && enginecapacity < 0)
            //    {
            //        result.AppendLine("The engine capacity and year are incorrect");
            //        Console.WriteLine(result);
            //    }
            //    else if (year < 1980 || year > 2025)
            //    {
            //        result.AppendLine("The year is incorrect");
            //        Console.WriteLine(result);
            //    }
            //    else if (enginecapacity < 0)
            //    {
            //        result.AppendLine("The engine capacity is incorrect");
            //        Console.WriteLine(result.ToString());
            //    }
            //    else if (year >= 1980 && year <= 2025)
            //    {
            //        if (enginecapacity > 0)
            //        {
            //            Console.WriteLine(vehicle);
            //        }
            //    }
            //}
            ////Task 2
            //decimal balance = 10000;
            //int menu = 0;
            //while (menu != 4)
            //{
            //    Console.WriteLine("1.Check balance");
            //    Console.WriteLine("2.Deposit");
            //    Console.WriteLine("3.Withdraw");
            //    Console.WriteLine("4.Exit");
            //    menu = int.Parse(Console.ReadLine());
            //    switch (menu)
            //    {
            //        case 1:
            //            Console.WriteLine($"Your balance is {balance}");
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter amount");
            //            decimal deposit = decimal.Parse(Console.ReadLine());
            //            balance += deposit;
            //            break;
            //        case 3:
            //            if (balance > 0)
            //            {
            //                Console.WriteLine("Enter amount");
            //                decimal withdraw = decimal.Parse(Console.ReadLine());
            //                balance -= withdraw;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Insufficient funds");
            //            }
            //            break;
            //        case 4:
            //            menu = 4;
            //            break;
            //    }
            //}
            ////Task 3
            //int a = 0;
            //decimal total = 0;
            //StringBuilder products = new StringBuilder();
            //while (a < 5)
            //{
            //    Console.WriteLine("Enter up to 5 products");
            //    string product = Console.ReadLine();
            //    Console.WriteLine("Enter price");
            //    decimal price = decimal.Parse(Console.ReadLine());
            //    products.AppendLine(product + " " + price + "$");
            //    total += price;
            //    a++;
            //    if (a < 5)
            //    {
            //        Console.WriteLine("Would you like to add products?(yes,no)");
            //        string add = Console.ReadLine();
            //        if (add == "yes")
            //        {
            //        }
            //        else
            //        {
            //            a = 5;
            //        }
            //    }
            //}
            //if (total > 100)
            //{
            //    Console.WriteLine($"{products}Total: Old price {total}");
            //    decimal discount = (total * 10) / 100;
            //    total = total - discount;
            //    Console.WriteLine($"New price {total}$");
            //}
            //else
            //{
            //    Console.WriteLine($"{products}Total: {total}$");
            //}
            ////Task 4
            ///
            //StringBuilder result = new StringBuilder();
            //Console.WriteLine("Enter Employee name");
            //string? name = Console.ReadLine();
            //result.AppendLine($"Name {name}");
            //Console.WriteLine("Enter day of the week");
            //string? day = Console.ReadLine();
            //result.AppendLine($"Day {day}");
            //Console.WriteLine("Enter start time (1 - 24)");
            //int start = int.Parse(Console.ReadLine());
            //result.AppendLine($"Starting time {start}");
            //Console.WriteLine("Enter ending time (1 - 24)");
            //int end = int.Parse(Console.ReadLine());
            //result.AppendLine($"End time {end}");
            //int shift = end - start;
            //if (start >= 6 && end <= 12)
            //{
            //    result.AppendLine("Morning");
            //}
            //else if (start > 12 && end <= 18)
            //{
            //    result.AppendLine("Afternoon");
            //}
            //else if (start > 18 && end <= 24)
            //{
            //    result.AppendLine("Night");
            //}
            //if (shift < 0)
            //{
            //    shift = shift + 24;
            //}
            //else
            //{
            //    if (shift >= 12)
            //    {
            //        Console.WriteLine("You work more then 12 hours");
            //    }
            //}
            //var shortlong = (shift < 12) ? result.AppendLine("Short term") : result.AppendLine("Long term");
            //Console.WriteLine(result);
            ////Task 5
            ///
            //Console.WriteLine("Enter monthly income");
            //int? income = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("Enter expenses");
            //Console.WriteLine("Rent");
            //int? rent = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("Groceries");
            //int groceries = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("Transport");
            //int transport = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("Entertainment");
            //int entertainment = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("Other");
            //int other = int.Parse(Console.ReadLine() ?? "0");
            //int? expenses = rent + groceries + transport + entertainment + other;
            //int? total = income - expenses;
            //if (total < 0)
            //{
            //    Console.WriteLine("Balance is negative");
            //}
            //else if (expenses > ((income * 80) / 100))
            //{
            //    Console.WriteLine("More then 80% of income is spent");
            //}
            ////Bonus Task
            ///
            //string username = "gevorg";
            //string password = "password1234";
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Username");
            //    string? username1 = Console.ReadLine();
            //    Console.WriteLine("Password");
            //    string? password1 = Console.ReadLine();
            //    if (username1 == username && password1 == password)
            //    {
            //        Console.WriteLine("Correct");
            //        i = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect");
            //    }
            //}


            //string a = "4444";
            //string aa = (a != null) ? a : "00000";
            //Console.WriteLine(aa);

            //Task 1

            //Console.WriteLine("How old are you");
            //int age = int.Parse(Console.ReadLine());
            //string? result = (age < 13) ? "You are a child" : (age >= 13 && age <= 17) ? "You are a teenager" : (age >= 18 && age <= 64) ? "You are an adult" : (age >= 65) ? "You are a senior" : " ";
            //Console.WriteLine(result);

            //Task 2
            //1.

            //Console.WriteLine("Enter discount code");
            //string? code = Console.ReadLine();
            //if (code == "")
            //{
            //    code = null;
            //}
            //code = code ?? "NO CODE ENTERED";
            //Console.WriteLine(code);
            //2.

            //static extern bool IsNullOrWhiteSpace(string? value);
            //Console.WriteLine("Enter discount code");
            //string? code = Console.ReadLine();
            //String.IsNullOrWhiteSpace(code);
            //if (String.IsNullOrWhiteSpace(code) == true)
            //{
            //    Console.WriteLine("NO CODE ENTERED");
            //}
            //else
            //{
            //    Console.WriteLine(code);
            //}

            //Task 3

            //Product product = new Product();
            //for(int i = 0;i < 3; i++)
            //{
            //    Console.WriteLine("Enter Product name");
            //    product.Name = Console.ReadLine() ?? "";
            //    Console.WriteLine("Enter Product description");
            //    product.Description = Console.ReadLine();
            //    if (product.Description == "")
            //    {
            //        product.Description = null;
            //        product.Description = product.Description ?? "No description available";
            //    }

            //    Console.WriteLine($"Name: {product.Name}");
            //    Console.WriteLine($"Description: {product.Description}");
            //}

            //Task 4

            // Console.WriteLine("Enter preferred name.");
            // string? preferredname = Console.ReadLine();
            // Console.WriteLine("Enter nickname.");
            // string? nickname = Console.ReadLine();
            // Console.WriteLine("Enter username.");
            // string? username = Console.ReadLine();
            // if(preferredname == "")
            // {
            //     preferredname = null;
            // }
            // if (nickname == "")
            // {
            //     nickname = null;
            // }
            // if (username == "")
            // {
            //     username = null;
            // }
            // string? name = preferredname ?? nickname ?? username ?? "Guest";
            //Console.WriteLine($"Hello, {name}");

            //Task 5
            //        User user = new User();
            //        Console.WriteLine("Enter Bio");
            //        string? bio = user.Profile?.Bio;
            //        bio = Console.ReadLine();
            //        if(bio == "")
            //        {
            //            bio = null;
            //            bio = bio ?? "No bio set";
            //        }
            //        Console.WriteLine($"Bio: {bio}");
            //    }

            //Height calculator

            Console.WriteLine("Hi.If you want to calculate your height, you are in a right place.");
            Console.WriteLine("1.Boy");
            Console.WriteLine("2.Girl");
            int gender = int.Parse(Console.ReadLine());
            while (gender != 1 && gender != 2)
            {
                Console.WriteLine("Incorrect number option.Try again.");
                gender = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mother height");
            decimal mother = decimal.Parse(Console.ReadLine());
            while (mother <= 0)
            {
                Console.WriteLine("Height can't be negative or zero.");
                mother = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("Father height");
            decimal father = decimal.Parse(Console.ReadLine());
            while(father <= 0)
            {
                Console.WriteLine("Height cant't be negative or zero");
                father = decimal.Parse(Console.ReadLine());
            }
            decimal height = (father + mother) / 2;
            decimal height1 = 0;
            decimal height2 = 0;
            if (gender == 1)
            {
                height1 =  height + 6.5m;

            }
            else if(gender == 2)
            {
                height2 = height - 6.5m;
            }
            Console.WriteLine($"Predicted adult height is between {height}cm and {height1}cm");
        }

        //Task 3

        //class Product
        //{
        //    public string? Name;
        //    public string? Description;
        //}

        //Task 5
        //class Profile
        //{
        //    public string? Bio { get; set; }
        //    public Profile(string bio)
        //    {
        //        Bio = bio;
        //    }
        //}
        //class User
        //{
        //    public Profile? Profile { get; set; }
        //}
    }
}
