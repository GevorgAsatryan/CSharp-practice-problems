    internal class Program
    {
        class Program1
        {
            static void Main(string[] args)
            {
            //Task 1

            //Console.WriteLine("Enter baggage weight");
            //int weight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter class (Economy, Business, First)");
            //string class1 = Console.ReadLine();
            //int fee = 0;

            //if(class1 == "Economy" && weight >= 20)
            //{
            //    if(weight <= 20)
            //    {
            //        Console.WriteLine($"{fee}$");
            //    }
            //    if(weight > 20)
            //    {
            //        fee = 10 * (weight - 20);
            //        Console.WriteLine($"{fee}$");

            //    }
            //}
            //if(class1 == "Business" && weight >= 30)
            //{
            //    if (weight <= 30)
            //    {
            //        Console.WriteLine($"{fee}$");
            //    }
            //    if (weight > 30)
            //    {
            //        fee = 8 * (weight - 30);
            //        Console.WriteLine($"{fee}$");
            //    }
            //}
            //if(class1 == "First" && weight >= 40)
            //{
            //    if (weight <= 40)
            //    {
            //        Console.WriteLine($"{fee}$");
            //    }
            //    if (weight > 40)
            //    {
            //        fee = 5 * (weight - 40);
            //        Console.WriteLine($"{fee}$");
            //    }

            //Task 2

            //Console.WriteLine("Enter GPA.");
            //double gpa = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter attendance.");
            //int attendance = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter service hours.");
            //int hours = int.Parse(Console.ReadLine());

            //if(gpa >= 3.5 && attendance >= 90)
            //{
            //    if(hours >= 20)
            //    {
            //        Console.WriteLine("Full Scholarship");
            //    }
            //    else if(hours >= 10)
            //    {
            //        Console.WriteLine("Half Scholarship");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Academic Scholarship Only");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible");
            //}
            //Task 3

            //Console.WriteLine("Enter your annual income.");
            //int income = int.Parse(Console.ReadLine());
            //int tax = 0;
            //int total = 0;
            //if (income > 100000)
            //{
            //    tax = (10 * 50000) / 100;
            //    income -= 50000;
            //    total += tax;
            //    tax = (20 * 50000) / 100;
            //    income -= 50000;
            //    total += tax;
            //    tax = (30 * income) / 100;
            //    total += tax;
            //}
            //else if (income > 50000)
            //{
            //    tax = (10 * 50000) / 100;
            //    income -= 50000;
            //    total += tax;
            //    tax = (20 * income) / 100;
            //    total += tax;
            //}
            //else
            //{
            //    tax = (10 * income) / 100;
            //    total += tax;
            //}
            //Console.WriteLine($"Total tax {total}");

            //Task 4

            //    Console.WriteLine("Enter years of experience");
            //    int experience = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter education level (High School,Bachelor,Master)");
            //    string education = Console.ReadLine();
            //    Console.WriteLine("Enter skill test score");
            //    int score = int.Parse(Console.ReadLine());

            //    if (education == "Master" || education == "Bachelor")
            //    {
            //        if(experience >= 5)
            //        {
            //            if (score >= 80)
            //            {
            //                Console.WriteLine("Highly Eligible");
            //            }
            //            else if(score >= 60)
            //            {
            //                Console.WriteLine("Eligible");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Needs Improvement");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Not Enough Expirience");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Education Not Sufficient");
            //    }

            //Task 5

            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ticket type(Standard, Fast Pass)");
            //string ticket = Console.ReadLine();

            //if (age < 5)
            //{
            //    Console.WriteLine("Free");
            //}
            //if(age >= 5 && age <= 12)
            //{
            //    if(ticket == "Standard")
            //    {
            //        Console.WriteLine("10$");
            //    }
            //    else if(ticket == "Fast Pass")
            //    {
            //        Console.WriteLine("15$");
            //    }
            //}
            //else if (age >= 13 && age <= 64)
            //{
            //    if (ticket == "Standard")
            //    {
            //        Console.WriteLine("20$");
            //    }
            //    else if (ticket == "Fast Pass")
            //    {
            //        Console.WriteLine("30$");
            //    }
            //}
            //else if (age >= 65)
            //{
            //    if (ticket == "Standard")
            //    {
            //        Console.WriteLine("12$");
            //    }
            //    else if (ticket == "Fast Pass")
            //    {
            //        Console.WriteLine("18$");
            //    }
            //}

            //Task 6

            //Console.WriteLine("Item price.");
            //int price = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantity.");
            //int quantity = int.Parse(Console.ReadLine());
            //Console.WriteLine("Customer type (Regular, VIP).");
            //string customer = Console.ReadLine();
            //int finalprice = 0;

            //if (quantity > 100)
            //{
            //    if(customer == "VIP")
            //    {
            //        finalprice = (20 * price) / 100;
            //    }
            //    else if(customer == "Regular")
            //    {
            //        finalprice = (10 * price) / 100;
            //    }
            //}
            //else if (quantity > 50)
            //{
            //    if(customer == "VIP")
            //    {
            //        finalprice = (15 * price) / 100;
            //    }
            //    else if (customer == "Regular")
            //    {
            //        finalprice = (5 * price) / 100;
            //    }
            //}
            //else
            //{
            //    if (customer == "VIP")
            //    {
            //        finalprice = (10 * price) / 100;
            //    }
            //    else if (customer == "Regular")
            //    {
            //        Console.WriteLine("No discount");
            //    }
            //}
            //Console.WriteLine(price - finalprice);

            //Task 7

            //Console.WriteLine("Meal type(Breakfast, Lunch, Dinner)");
            //string meal = Console.ReadLine();
            //Console.WriteLine("Delivery or dine-in");
            //string deliverydinein = Console.ReadLine();
            //Console.WriteLine("Time");
            //int time = int.Parse(Console.ReadLine());

            //if(deliverydinein == "delivery")
            //{
            //    if(meal == "Dinner" && time >= 8)
            //    {
            //        Console.WriteLine("+$5 surcharge");
            //    }
            //    else if (meal == "Lunch")
            //    {
            //        Console.WriteLine("+$3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No surcharge");
            //    }
            //}
            //else if (deliverydinein == "dine-in")
            //{
            //    if (meal == "Breakfast" && time <= 8)
            //    {
            //        Console.WriteLine("+$2 early bird fee");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No surcharge");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No surcharge");
            //}

            //Task 8

            //Console.WriteLine("City (Tire 1, Tire 2)");
            //string city = Console.ReadLine();
            //Console.WriteLine("Apartment type (1BHK, 2BHK, 3BHK)");
            //string apartment = Console.ReadLine();
            //Console.WriteLine("Amenities (yes/no)");
            //string amenities = Console.ReadLine();
            //int rent = 0;
            //if(city == "Tire 1")
            //{
            //    if(apartment == "1BHK")
            //    {
            //        rent = 800;
            //    }
            //    if (apartment == "2BHK")
            //    {
            //        rent = 1200;
            //    }
            //    if (apartment == "3BHK")
            //    {
            //        rent = 1600;
            //    }
            //}
            //else if (city == "Tire 2")
            //{
            //    if (apartment == "1BHK")
            //    {
            //        rent = 600;
            //    }
            //    if (apartment == "2BHK")
            //    {
            //        rent = 900;
            //    }
            //    if (apartment == "3BHK")
            //    {
            //        rent = 1200;
            //    }
            //}
            //if (amenities == "yes")
            //{
            //    rent += 100;
            //}
            //Console.WriteLine(rent + "$");

            //Task 9

            //Console.WriteLine("Income");
            //int income = int.Parse(Console.ReadLine());
            //Console.WriteLine("Credit score");
            //int credit = int.Parse(Console.ReadLine());
            //Console.WriteLine("Age");
            //int age = int.Parse(Console.ReadLine());

            //if(age >= 21)
            //{
            //    if(income >= 30000)
            //    {
            //        if(credit >= 700)
            //        {
            //            Console.WriteLine("Approved");
            //        }
            //        else if(credit >= 600)
            //        {
            //            Console.WriteLine("Approved with low Limit");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Denied");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Low Income - Denied");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Too Young - Denied");
            //}

            //Task 10

            //Console.WriteLine("Age group (child, teen, adult)");
            //string agegroup = Console.ReadLine();
            //Console.WriteLine("IQ score");
            //int iq = int.Parse(Console.ReadLine());

            //if (agegroup == "child")
            //{
            //    if(iq >= 80 && iq <= 110)
            //    {
            //        Console.WriteLine("Average");
            //    }
            //    else if(iq > 110)
            //    {
            //        Console.WriteLine("Gifted");
            //    }
            //    else if(iq < 80)
            //    {
            //        Console.WriteLine("Needs Support");
            //    }
            //}
            //else if (agegroup == "teen")
            //{
            //    if (iq >= 90 && iq <= 120)
            //    {
            //        Console.WriteLine("Average");
            //    }
            //    else if (iq > 120)
            //    {
            //        Console.WriteLine("Advanced");
            //    }
            //    else if (iq < 90)
            //    {
            //        Console.WriteLine("Below Normal");
            //    }
            //}
            //else if (agegroup == "adult")
            //{
            //    if (iq >= 100 && iq <= 130)
            //    {
            //        Console.WriteLine("Normal");
            //    }
            //    else if (iq > 130)
            //    {
            //        Console.WriteLine("High IQ");
            //    }
            //    else if (iq < 100)
            //    {
            //        Console.WriteLine("Below Normal");
            //    }
            //}

            //Task 1

            //Console.WriteLine("Add item codes (A: Apple, B: Bread, C: Cheese, done: to finish)");
            //string item = Console.ReadLine();
            //int cost = 0;
            //while (item != "done")
            //{
            //    switch (item)
            //    {
            //        case "A":
            //            Console.WriteLine("$2");
            //            cost += 2;
            //            break;
            //        case "B":
            //            Console.WriteLine("$3");
            //            cost += 3;
            //            break;
            //        case "C":
            //            Console.WriteLine("$5");
            //            cost += 5;
            //            break;
            //        case "done":
            //            break;
            //    }
            //    item = Console.ReadLine();
            //}
            //Console.WriteLine(cost + "$");

            //Task 2

            //Console.WriteLine("Enter numbers");
            //string number = Console.ReadLine();

            //while (number != "exit")
            //{
            //    int number1 = int.Parse(number);
            //    if (number1 < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else if(number1 == 0)
            //    {
            //        Console.WriteLine("Zero");
            //    }
            //    else if (number1 > 0)
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //    Console.WriteLine("Enter numbers");
            //    number = Console.ReadLine();
            //}

            //Task 3

            //int guess = 0;
            //int correct = 5407;

            //do
            //{
            //    Console.WriteLine("Guess the 4-digit code");
            //    guess = int.Parse(Console.ReadLine());
            //    if (guess < 5400)
            //    {
            //        Console.WriteLine("Too low");
            //    }
            //    else if(guess > 5500)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //}
            //while (guess != correct);

            //Task 4

            //Random ran = new Random();
            //string quit = Console.ReadLine();
            //while (quit != "quit")
            //{
            //    int a = ran.Next(1, 11);
            //    int b = ran.Next(1, 11);
            //    int c = ran.Next(1, 11);
            //    Console.WriteLine($"{a},{b},{c}");
            //    if(a == b && a == c && b == c)
            //    {
            //        Console.WriteLine("Big Win");
            //    }
            //    else if(a == b || a == c || b == c)
            //    {
            //        Console.WriteLine("Small Win");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try again");
            //    }
            //        quit = Console.ReadLine();
            //}

            //Task 5

            //string username;
            //string password;
            //string correct = "username";
            //string correct1 = "password";
            //int tries = 3;
            //do
            //{
            //    Console.WriteLine("Username");
            //    username = Console.ReadLine();
            //    Console.WriteLine("Password");
            //    password = Console.ReadLine();
            //    if(username == correct && password == correct1)
            //    {
            //        Console.WriteLine("Login Successful");
            //        tries = 0;
            //    }
            //    tries--;
            //}
            //while (tries > 0);
            //if(tries == 0)
            //{
            //    Console.WriteLine("Account Locked");
            //}

            //Task 6

            //int atm = 0;
            //while(atm != 4)
            //{
            //    Console.WriteLine("1. Check Balance, 2. Deposit, 3. Withdraw, 4. Exit");
            //    atm = int.Parse(Console.ReadLine());
            //    switch (atm)
            //    {
            //        case 1:
            //            Console.WriteLine("Balance is updated");
            //            break;
            //        case 2:
            //            Console.WriteLine("Balance is updated");
            //            break;
            //        case 3:
            //            Console.WriteLine("Balance is updated");
            //            break;
            //        case 4:
            //            atm = 4;
            //            break;
            //    }

            //}

            //Task 7

            //int score = 1;
            //while (score > 0)
            //{
            //    Console.WriteLine("Enter scores 0-100");
            //    score = int.Parse(Console.ReadLine());
            //    if (score >= 70 && score <= 100)
            //    {
            //        Console.WriteLine("A");
            //    }
            //    else if (score >= 60 && score <= 69)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else if (score >= 50 && score <= 59)
            //    {
            //        Console.WriteLine("C");
            //    }
            //    else if (score >= 40 && score <= 49)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else if (score >= 0 && score <= 39)
            //    {
            //        Console.WriteLine("F");
            //    }
            //}

            //Task 8 

            //int hours;

            //while (true)
            //{
            //    Console.WriteLine("Enter parked hours");
            //    hours = int.Parse(Console.ReadLine());

            //    if (hours >= 1 && hours <= 2)
            //    {
            //        Console.WriteLine("$5");
            //    }
            //    else if (hours >= 3 && hours <= 5)
            //    {
            //        Console.WriteLine("$10");
            //    }
            //    else if (hours > 5)
            //    {
            //        Console.WriteLine("$15");
            //    }
            //}

            //Task 9

            //int price = 1;

            //while (price > 0)
            //{
            //    Console.WriteLine("Item price");
            //    price = int.Parse(Console.ReadLine());
            //    if (price > 100)
            //    {
            //        Console.WriteLine("You have got 10% discount");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You haven't got discount");
            //    }
            //}

            //Task 10
            //bool a = true;
            //do
            //{
            //    Console.WriteLine("1. Start Game, 2. Load game, 3. Quit");
            //    int game = int.Parse(Console.ReadLine());
            //    switch (game)
            //    {
            //        case 1:
            //            Console.WriteLine("1.The game has started");
            //            break;
            //        case 2:
            //            Console.WriteLine("1.The game has loaded");
            //            break;
            //        case 3:
            //            a = false;
            //            break;
            //    }
            //}
            //while (a);

            //Task 1

            //Console.WriteLine("Enter a number.");
            //string number = Console.ReadLine();
            //int number2 = int.Parse(number);

            //while (number2 >= 0)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine(number2);
            //    number2--;
            //}

            //Task 2

            //int pin = 0;
            //int correct = 1234;
            //int attempts = 3;

            //while (attempts > 0)
            //{
            //    Console.WriteLine("Enter a 4-digit PIN");
            //    pin = int.Parse(Console.ReadLine());

            //    if (pin == correct)
            //    {
            //        Console.WriteLine("Access Granted");
            //        attempts = 0;
            //    }
            //    attempts--;
            //    if (attempts == 0)
            //    {
            //        Console.WriteLine("Account Locked");
            //    }
            //}

            //Task 3


            //Console.WriteLine("Enter month (1-12) and years");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter year");
            //int year = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine(31 + "days");
            //        break;
            //    case 2:
            //        if(year % 4 == 0)
            //        {
            //            Console.WriteLine(29 + "days");
            //        }
            //        else
            //        {
            //            Console.WriteLine(28 + "days");
            //        }
            //            break;
            //    case 3:
            //        Console.WriteLine(31 + "days");
            //        break;
            //    case 4:
            //        Console.WriteLine(30 + "days");
            //        break;
            //    case 5:
            //        Console.WriteLine(31 + "days");
            //        break;
            //    case 6:
            //        Console.WriteLine(30 + "days");
            //        break;
            //    case 7:
            //        Console.WriteLine(31 + "days");
            //        break;
            //    case 8:
            //        Console.WriteLine(30 + "days");
            //        break;
            //    case 9:
            //        Console.WriteLine(31 + "days");
            //        break;
            //    case 10:
            //        Console.WriteLine(30 + "days");
            //        break;
            //    case 11:
            //        Console.WriteLine(31 + "days");
            //        break;
            //    case 12:
            //        Console.WriteLine(30 + "days");
            //        break;
            //}

            //Task 4

            //Console.WriteLine("Enter speed(km/h)");
            //string speed = Console.ReadLine();
            //Console.WriteLine("Enter time(hours)");
            //string time = Console.ReadLine();
            //float speed1 = float.Parse(speed);
            //float time1 = float.Parse(time);
            //float t = time1;
            //while (t > 0)
            //{
            //    Console.WriteLine((time1 - (t - 1)) * speed1 + "km");
            //    t--;
            //}

            //Task 5

            //int a;

            //do
            //{
            //    Console.WriteLine("1. Print Hello, 2. Print Date, 3. Exit");
            //    a = int.Parse(Console.ReadLine());
            //    switch (a)
            //    {
            //        case 1:
            //            break;
            //        case 2:
            //            break;
            //        case 3:
            //            break;
            //    }
            //}
            //while (a < 3);

            //Task 6

            //Console.WriteLine("Enter a number");
            //string number = Console.ReadLine();
            //int number1 = int.Parse(number);
            //int division;
            //for(int i = 1;i <= 10; i++)
            //{
            //   division = number1 / i;
            //    Console.WriteLine($"{number} / {i} = {division}");
            //}

            //Task 7

            //Console.WriteLine("Enter an amount");
            //string amount = Console.ReadLine();
            //double amount1 = double.Parse(amount);
            //Console.WriteLine("1.USD, 2.EUR, 3.GBP");
            //int currency = int.Parse(Console.ReadLine());

            //switch (currency)
            //{
            //    case 1:
            //        Console.WriteLine(amount1 +"AMD" + "=" + amount1 / 385 + "USD");
            //        break;
            //    case 2:
            //        Console.WriteLine(amount1 + "AMD" + "=" + amount1 /  424 + "EUR");
            //        break;
            //    case 3:
            //        Console.WriteLine(amount1 + "AMD" + "=" + amount1 / 504 + "GBP");
            //        break;
            //}

            //Task 8

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();
            //int age1 = int.Parse(age);

            //if(age1 >= 0 && age1 <= 12)
            //{
            //    Console.WriteLine("Child");
            //}
            //else if (age1 >= 13 && age1 <= 17)
            //{
            //    Console.WriteLine("Teen");
            //}
            //else if (age1 >= 18 && age1 <= 64)
            //{
            //    Console.WriteLine("Adult");
            //}
            //else if (age1 >= 65)
            //{
            //    Console.WriteLine("Senior");
            //}

            //Task 9

            //Console.WriteLine("Enter a positive integer");
            //string integer = Console.ReadLine();
            //int count = 0;
            //for(int i = 0;i < integer.Length; i++)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);

            //Task 10

            //Console.WriteLine("Enter height in cm");
            //string height = Console.ReadLine();
            //int height1 = int.Parse(height);
            //Console.WriteLine("Enter age");
            //string age = Console.ReadLine();
            //int age1 = int.Parse(age);

            //if(age1 >= 12 && height1 >= 140)
            //{
            //    Console.WriteLine("Allowed");
            //}
            //else if (age1 >= 10 && height1 >= 130)
            //{
            //    Console.WriteLine("With Parent");
            //}
            //else
            //{
            //    Console.WriteLine("Not Allowed");
            //}

            //Task 1

            //int a;
            //int b;
            //string c = null; ;
            //int count = 0;
            //int a1 = 0;
            //while(a1 != 1)
            //{
            //    Console.WriteLine("Enter two numbers");
            //        a = int.Parse(Console.ReadLine());
            //        b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter operation (+, -, *, /,)");
            //        c = Console.ReadLine();
            //    switch (c)
            //    {
            //        case "+":
            //            count = a + b;
            //            break;
            //        case "-":
            //            count = a - b;
            //            break;
            //        case "*":
            //            count = a * b;
            //            break;
            //        case "/":
            //            count = a / b;
            //            break;
            //    }
            //    Console.WriteLine(count);
            //    Console.WriteLine("1. Quit, 2. Again");
            //    a1 = int.Parse(Console.ReadLine());
            //    if(a1 == 1)
            //    {
            //        a1 = 1;
            //    }
            //    else if(a1 == 2)
            //    {
            //        a1 = 2;
            //    }
            //}



            //Task 2

            //string weight;
            //float weight1 = 1;
            //string speed;
            //while (weight1 > 0)
            //{ 
            //    Console.WriteLine("Enter weight");
            //    weight = Console.ReadLine();
            //    weight1 = float.Parse(weight);
            //    Console.WriteLine("Enter speed (Standard/Express)");
            //    speed = Console.ReadLine();

            //    if (speed == "Standard")
            //    {
            //        Console.WriteLine(5 + 1 / weight1 + "$");
            //    }
            //    else if (speed == "Express")
            //    {
            //        Console.WriteLine(10 + 2 / weight1 + "$");
            //    }
            //}

            //Task 3

            //string a = null;

            //while (a != "q")
            //{
            //    Console.WriteLine("Enter a decimal number or q for exit");
            //    a = Console.ReadLine();
            //    if(a == "q")
            //    {
            //        a = "q";
            //    }
            //    else
            //    {
            //        var number = (int)decimal.Parse(a, System.Globalization.NumberStyles.Number, CultureInfo.InvariantCulture);
            //        var b = Convert.ToString(number, 2);
            //        var c = Convert.ToString(number, 16);
            //        Console.WriteLine(b);
            //        Console.WriteLine(c);
            //    }


            //}

            //Task 4

            //string name;
            //string done;
            //do
            //{
            //    Console.WriteLine("Enter product name.");
            //    name = Console.ReadLine();
            //    Console.WriteLine("Enter price.");
            //    string price = Console.ReadLine();
            //    double price1 = double.Parse(price);
            //    Console.WriteLine("Enter quantity");
            //    int quantity = int.Parse(Console.ReadLine());
            //    double discount;
            //    if (quantity >= 10)
            //    {
            //        discount = (10 * price1) / 100;
            //        Console.WriteLine(price1 - discount);
            //    }
            //    Console.WriteLine("Enter done if you finished");
            //    done = Console.ReadLine();
            //}
            //while (done != "done");

            //Task 5

            //Console.WriteLine("Enter marks from 5 subjects");
            //string mark1 = Console.ReadLine();
            //string mark2 = Console.ReadLine();
            //string mark3 = Console.ReadLine();
            //string mark4 = Console.ReadLine();
            //string mark5 = Console.ReadLine();
            //int mark1_1 = int.Parse(mark1);
            //int mark1_2 = int.Parse(mark2);
            //int mark1_3 = int.Parse(mark3);
            //int mark1_4 = int.Parse(mark4);
            //int mark1_5 = int.Parse(mark5);
            //int total = 0;
            //int average = 0;
            //int[] arr = { mark1_1 , mark1_2 , mark1_3 , mark1_4 , mark1_5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    total = total + arr[i];
            //    average = total / 5;
            //}
            //if (average >= 90)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (average >= 75 && average <= 89)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (average < 75)
            //{
            //    Console.WriteLine("Needs Improvement");
            //}

            //Task 6

            //Console.WriteLine("Enter basic salary.");
            //string salary = Console.ReadLine();
            //float basic = float.Parse(salary);
            //float hra = (20 * basic) / 100;
            //float da = (10 * basic) / 100;
            //float tax = (5 * basic) / 100;
            //float final;
            //final = basic + hra + da - tax;
            //Console.WriteLine($"final salary {final}, basic {basic}, HRA {hra}, DA {da}, tax {tax}");

            //Task 7

            //int a = 1;
            //int total = 0;
            //string name = null;
            //int price1 = 0;
            //int quantity1 = 0;
            //while (a <= 3)
            //{

            //    Console.WriteLine("Enter name");
            //    name = Console.ReadLine();
            //    Console.WriteLine("Enter price");
            //    string price = Console.ReadLine();
            //    price1 = int.Parse(price);
            //    Console.WriteLine("Enter quantity");
            //    string quantity = Console.ReadLine();
            //    quantity1 = int.Parse(quantity);
            //    a++;
            //    total += price1;
            //    Console.WriteLine($"Item {a}: {name}, quantity {quantity1}");
            //}

            //Console.WriteLine($"Total cost {total}");

            //Task 8

            //int i = 0;
            //string result = "";

            //for(i = 0;i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        result += "FizzBuzz";
            //        Console.WriteLine($"{i} {result}");
            //        result = "";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        result += "Fizz";
            //         Console.WriteLine($"{i} {result}");
            //        result = "";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        result += "Buzz";
            //        Console.WriteLine($"{i} {result}");
            //        result = "";
            //    }
            //    else
            //    {
            //        Console.Write("");
            //    }
            //}

            //Task 9

            //Console.WriteLine("Enter product price");
            //string price = Console.ReadLine();
            //int price1 = int.Parse(price);
            //Console.WriteLine("Enter Category (Essential, Luxury)");
            //string category = Console.ReadLine();
            //int tax = 0;

            //switch (category)
            //{
            //    case "Essential":
            //        tax = (price1 * 5) / 100;
            //        break;
            //    case "Luxury":
            //        tax = (price1 * 15) / 100;
            //        break;
            //}

            //Console.WriteLine($"Final amount {price1 - tax}");

            //Task 10

            //double a = 0;

            //while (a >= 0)
            //{
            //    Console.WriteLine("Enter principal.");
            //    string principal = Console.ReadLine();
            //    double principal1 = double.Parse(principal); ;
            //    Console.WriteLine("Enter rate.");
            //    string rate = Console.ReadLine();
            //    double rate1 = double.Parse(principal);
            //    Console.WriteLine("Enter years.");
            //    string years = Console.ReadLine();
            //    double years1 = double.Parse(years);


            //    a = principal1 * (1 + rate1 / 100);

            //}

            //1.

            //Random random = new Random();
            //int a = 0;
            //int sum = 0;
            //decimal average;
            //int max = 0;
            //int min = 10;
            //int[] numbers;
            ////int[] numbers = [];
            //Array array = Array.CreateInstance(typeof(int),10);
            //for (int i = 0;i < 10; i++)
            //{
            //    a = random.Next(1, 10);
            //    Console.WriteLine(a);
            //    array.SetValue(a , i);
            //    sum += a;
            //    if(a > max)
            //    {
            //        max = a;
            //    }
            //    if(a < min)
            //    {
            //        min = a;
            //    }
            //}
            //average = sum / 100;

            //Console.WriteLine($"sum {sum}");
            //Console.WriteLine($"average {average}");
            //Console.WriteLine($"max {max}");
            //Console.WriteLine($"min {min}");
            //Console.WriteLine(Array.IndexOf(array , 1));

            //2.

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 4, 7, 4 };
            //int mid = numbers.Length / 2;
            //int index = Array.IndexOf(numbers, mid);
            //Console.WriteLine(index);

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] numbers2 = new int[10];
            //int a = 0;
            //for(int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    numbers2[a] = numbers[i];
            //    a++;
            //}
            //for(int i = 0;i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}
            
        }


    }

    }
