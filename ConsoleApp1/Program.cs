// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        ////ilsdam
        ////sensetive lenguage capital,small letters
        //string ss = "Gevorg";
        //string ww = "Asatryan";
        //string fullname = string.Concat(ss, ww);
        //Console.WriteLine(fullname);
        ////Task 1

        //Console.WriteLine("Hi.What is your name?");
        //string name = Console.ReadLine();
        //Console.WriteLine($"Hello,{name}! Welcome to your first C# program.");

        ////Task 2
        //Console.WriteLine("Enter two numbers.");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int s = a - b;
        //int m = a * b;
        //int d = a / b;
        //Console.WriteLine($"Your numbers are {a} and {b}.");
        //Console.WriteLine($"{a}-{b}={s}");
        //Console.WriteLine($"{a}*{b}={m}");
        //Console.WriteLine($"{a}/{b}={d}");

        ////Task 3
        //Console.WriteLine("What is your favorite color?");
        //string color = Console.ReadLine();
        //Console.WriteLine("What is your favorite food?");
        //string food = Console.ReadLine();
        //Console.WriteLine("What is your favorite number?");
        //string number = Console.ReadLine();
        //Console.WriteLine($"You love {color},{food}, and your lucky numver is {number}");

        ////Task 4
        //Console.WriteLine("What is your first name?");
        //string firstname = Console.ReadLine();
        //Console.WriteLine("What is your Last name?");
        //string lastname = Console.ReadLine();
        //Console.WriteLine("How old are you?");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine("Where are you from?");
        //string country = Console.ReadLine();
        //Console.WriteLine($"Your name is {firstname} {lastname},you are {age} years old and you live in {country}");

        ////Task 5
        //Console.WriteLine("Enter a number of hours to convert it to minutes.");
        //int hours = int.Parse(Console.ReadLine());
        //int minutes = hours * 60;
        //Console.WriteLine($"That's {minutes} minutes.");

        //Task 1
        //Version 1.(manually)
        //Console.WriteLine("Hi.Enter 8 letter word.");
        //string word = Console.ReadLine();
        //Console.Write(word[7]);
        //Console.Write(word[6]);
        //Console.Write(word[5]);
        //Console.Write(word[4]);
        //Console.Write(word[3]);
        //Console.Write(word[2]);
        //Console.Write(word[1]);
        //Console.Write(word[0]);

        ////Version 2.
        //Console.WriteLine("Hi.Enter 8 letter word.");
        //string word1 = Console.ReadLine();

        //for (int i = word1.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(word1[i]);
        //}
        //Task 2

        //Console.WriteLine("Enter any word you want");
        //string word = Console.ReadLine();
        //char firstletter = word[0];
        //char lastletter = word[word.Length - 1];
        //char winner;
        //if (firstletter > lastletter)
        //{
        //    winner = lastletter;
        //}
        //else
        //{
        //    winner = firstletter;
        //}
        //Console.WriteLine($"Between {firstletter} and {lastletter},{winner} wins!");

        //Task 3
        //Console.WriteLine("Enter your favorite color");
        //string color = Console.ReadLine().ToUpper();
        //Console.WriteLine("Enter your favorite animal");
        //string animal = Console.ReadLine();
        //Console.WriteLine($"{color} {animal}");

        //Task 4
        //Console.WriteLine("Enter 6 letter word");
        //string word = Console.ReadLine();
        //char letter1 = word[1];
        //char letter2 = word[3];
        //char letter3 = word[5];

        //Console.WriteLine($"{letter1}{letter2}{letter3}");

        //Task 5

        //Console.WriteLine("Enter 2 letters to know the distance between them.");
        //string w1 = Console.ReadLine();
        //string w2 = Console.ReadLine();

        //int char1 = w1[0];
        //int char2 = w2[0];

        //Console.WriteLine(char2 - char1);

        //Task 6
        //Console.WriteLine("Enter a word");
        //string word = Console.ReadLine();
        //string uppercase = word.ToUpper();
        //string lowercase = word.ToLower();
        //Console.WriteLine(uppercase + lowercase);

        //Task 7

        //Console.WriteLine("Write a word.");
        //string word = Console.ReadLine();
        //int word1 = (word.Length) / 2;
        //int word2 = word.Length;
        //for (int i = 0; i < word1; i++)
        //{
        //    Console.Write(word[i]);

        //}
        //Console.WriteLine();
        //for (int e = word1; e < word2; e++)
        //{
        //    Console.Write(word[e]);
        //}

        //Task 8
        //Version 1(only 4 letters)
        //Console.WriteLine("Write 4 letter word");
        //string word4 = Console.ReadLine();
        //Console.WriteLine($"{word4[word4.Length - 1]}{word4[1]}{word4[2]}{word4[0]}");
        ////Version 2
        //Console.WriteLine("Write a word");
        //string newword = null;
        //for (int i = 1; i < word4.Length - 1; i++)
        //{

        //    newword += word4[i];

        //}
        //Console.Write($"{word4[word4.Length - 1]}{newword}{word4[0]}");

        //Task 9

        //Console.WriteLine("Write 2 letters");
        //char first = Console.ReadLine()[0];
        //char second = Console.ReadLine()[0];

        //int a = first;
        //int b = second;
        //int difference = b - a;

        //Console.WriteLine($"{first}:{a},{second}:{b},Difference:{difference}");

        //Bonus Challenges
        //1.
        //    Console.WriteLine("What is your name?");
        //    string name = Console.ReadLine();

        //    for (int i = name.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(name[i]);
        //    }
        //    //2.
        //    Console.WriteLine();
        //    Console.WriteLine("Enter fruit name.");
        //    string fruit = Console.ReadLine();
        //    char middle = fruit[fruit.Length / 2];
        //    Console.WriteLine(middle);
        //    //3.
        //    Console.WriteLine("Enter 5 letter word");
        //    string letter5 = Console.ReadLine();
        //    int sum = 0;
        //    for (int i = 0; i <= letter5.Length - 1; i++)
        //    {
        //        sum += letter5[i];
        //    }
        //    Console.WriteLine(sum);
        //    //4.
        //    Console.WriteLine("Enter 2 words.");
        //    string word1 = Console.ReadLine();
        //    string word2 = Console.ReadLine();

        //    Console.WriteLine($"{word1}-{word2}");

        //    //5.
        //    Console.WriteLine("Enter your birth month.");
        //    string month = Console.ReadLine();
        //    Console.WriteLine("Enter your birth day.");
        //    int day = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"{day} {month}");
        //int i = 0;
        //int student = 1;
        //Console.WriteLine("How many times to input?");
        //int s = int.Parse(Console.ReadLine());
        //while(i < s)
        //{
        //    Console.WriteLine($"Student {student}");
        //    Console.WriteLine("Name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Age");
        //    int age = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Profession");
        //    string surname = Console.ReadLine();
        //    i++;
        //    student++;

        //}
        //Console.WriteLine("Enter a number");
        //int number = int.Parse(Console.ReadLine());
        //int sum = 0;
        //while(number > 0)
        //{
        //    Console.WriteLine("Would you like to exit from cycle?(yes or no)");
        //    string yesno = Console.ReadLine().ToLower();
        //    if(yesno == "yes")
        //    {
        //        number -= number;
        //    }
        //    else
        //    {
        //        sum += number;
        //        number--;
        //    }

        //}
        //Console.WriteLine(sum);

        //Task 1
        //Console.WriteLine("Hi.How many liters of fuel would you want to pump? 1 liter is 500AMD");
        //int total = int.Parse(Console.ReadLine());
        //int liters = 0;
        //int cost = 0;
        //while(liters < total)
        //{
        //    liters++;
        //    Console.WriteLine($"Pumped 1 liter.Total{liters}");
        //    cost += 500;
        //}
        //Console.WriteLine($"Total price {cost} AMD");
        //Task 2
        //bool yesno = true;
        //do
        //{
        //    Console.WriteLine("Would you like to snooze the alarm?(Y/N)");
        //    string answer = Console.ReadLine().ToUpper();
        //    if(answer == "Y")
        //    {
        //        Console.WriteLine("Snoozing for 5 more minutes.");
        //    }
        //    else
        //    {
        //        yesno = false;
        //    }
        //}
        //while(yesno);
        //Task 3
        //int attempts = 0;
        //do
        //{
        //    Console.WriteLine("Enter your PIN.");
        //    int pin = int.Parse(Console.ReadLine());
        //    if(pin == 1234)
        //    {
        //        Console.WriteLine("Correct.");
        //        attempts = 4;
        //    }
        //    else
        //    {
        //        attempts++;
        //        if (attempts == 3)
        //        {
        //            Console.WriteLine("Card Blocked.");
        //        }
        //    }

        //}
        //while(attempts < 3);
        //Task 4
        //int dice = 0;
        //Console.WriteLine(dice);
        //while (dice < 6)
        //{
        //    Console.WriteLine("Dice Roll.");
        //    Console.ReadLine();
        //    Random ran = new Random();
        //    int roll = ran.Next(1, 7);
        //    Console.WriteLine(roll);
        //    dice = roll;

        //    }
        //Task 5
        //Console.WriteLine("How many packages are left to diliver?");
        //int packages = int.Parse(Console.ReadLine());
        //while(packages > 0)
        //{
        //    packages--;
        //    Console.WriteLine($"Remain {packages} packages");
        //}
        //Task 6

        //string store = null;
        //bool yes = true;
        //do
        //{
        //    Console.WriteLine("Would you like to add more to the order?");
        //    string food = Console.ReadLine().ToLower();
        //    if(food == "no")
        //    {
        //        yes = false;
        //    }
        //    else
        //    {
        //        store += food + "/";
        //    }

        //}
        //while(yes);
        //Console.WriteLine($"Your order list: {store}");
        //Task 7
        //int price = 100;
        //while (price <= 120)
        //{
        //    Console.ReadLine();
        //    Random ran = new Random();
        //    int updown = ran.Next(-5, 6);
        //    price += updown;
        //    Console.WriteLine($"Price {price}");
        //}
        //Task 1
        //Console.WriteLine("Enter height.");
        //int n = int.Parse(Console.ReadLine());
        //string asterisks = "*";
        //while (n > 0)
        //{
        //    Console.WriteLine(asterisks);
        //    n--;
        //    asterisks += "*";
        //}
        //Task 2
        //    int n = 5;
        //    while (n > 0)
        //    {
        //        string asterisks = new string('*', n);
        //        Console.WriteLine(asterisks);
        //        n--;
        //    }
        //Task 3
        //int n = 4;

        //while(n > 0)
        //{
        //    Console.WriteLine("####");

        //    while(n > 2)
        //    {
        //        Console.WriteLine("####");
        //        n--;
        //    }
        //    n--;
        //}

        //int a = 0;
        //for (int i = 4; i > a; i--)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.Write("#");

        //    }
        //    Console.WriteLine();
        //}
        //Task 4
        //int n = 5;
        //while(n > 4)
        //{
        //    Console.WriteLine(new string('#', 5));
        //    while(n > 2)
        //    {
        //        Console.WriteLine("#   #");
        //        n--;
        //    }
        //    n--;
        //    Console.WriteLine(new string('#', 5));
        //}
        //Task 5

        //int n = 4;
        //string asterisks = "*";
        //int space = 3;

        //while (n > 0)
        //{
        //    Console.WriteLine(new string(' ', space) + asterisks + new string(' ', space));
        //    asterisks = asterisks + "**";
        //    space -= 1;
        //    n--;

        //}
        //Task 6
        //int n = 4;
        //int space = 3;
        //string asterisks = "*";
        //while (n > 0)
        //{
        //    Console.WriteLine(new string(' ', space) + asterisks);
        //    space--;
        //    asterisks = asterisks + "*";
        //    n--;
        //}
        //1.
        //for(int i = 1;i <= 4; i++)
        //{
        //    Console.WriteLine(new string('*', i));
        //2.
        //}
        //Console.WriteLine();
        //for(int i = 4; i > 0; i--)
        //{
        //    Console.WriteLine(new string('*',i));
        //}
        //3.
        //int a = 4;
        //for(int i = 0;i < a; i++)
        //{
        //    for(int j = 0;j <= i; j++)
        //    {
        //        Console.Write("4");

        //    }
        //    Console.WriteLine();
        //}
        //4.
        //int s = int.Parse(Console.ReadLine());
        //int a = s - 1;
        //for (int i = 1; i <= s; i++)
        //{
        //    Console.Write(new string('*', i));
        //    Console.WriteLine(new string('#', a));
        //    a--;
        //}
        //5.
        //    Console.WriteLine("Enter your age.");
        //    int age = int.Parse(Console.ReadLine());
        //    if(age > 21)
        //    {
        //        Console.WriteLine("Is citizen");
        //    }
        //    if(age < 18)
        //    {
        //        Console.WriteLine("Isn't citizen");
        //    }
        //    if(age > 18)
        //    {
        //        Console.WriteLine("Where are you from?");
        //    }
        //    string country = Console.ReadLine();
        //    if (country == "Armenia")
        //    {
        //        Console.WriteLine("Is Armenian");
        //    }
        //    if(country == "USA")
        //    {
        //        Console.WriteLine("Is citizen of USA");
        //    }
        //6.
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        //int max = 0;
        //if (a > b)
        //{
        //    max = b;
        //}
        //if(a < b)
        //{
        //    max = b;
        //}
        //if(c > max)
        //{
        //    max = c;
        //}
        //Console.WriteLine(max);
        //7.
        //Console.WriteLine("Name.");
        //string name = Console.ReadLine();
        //Console.WriteLine("How old are you?");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine("Where are you from?");
        //string country = Console.ReadLine().ToLower();
        //Console.WriteLine("Do you have id");
        //string hasid = Console.ReadLine().ToLower();
        //string adult = null;
        //string citizen = null;
        //if(age < 18)
        //{
        //    adult = "not adult";
        //}
        //if (hasid == "yes")
        //{
        //    if (age >= 18 && country == "armenia")
        //    {

        //        adult = "adult";
        //        citizen = "Armenia";

        //    }

        //    if (age >= 21 && country == "usa")
        //    {

        //        adult = "adult";
        //        citizen = "USA";

        //    }
        //}
        //if(hasid == "no")
        //{
        //    adult = "not adult";
        //}
        //Console.WriteLine($"Name:{name},Age:{age},Citizen:{citizen},{adult}");

        //string a = string.Format("My name is {0}.Surname is {1}", "Gevorg","Asatryan");
        //Console.WriteLine(a);

        //int a, b, c;
        //a = b = c = 4;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);

        //int a = 7;
        //int b = a;
        //int c = b++; 
        ////c = 7 then b++ b = 8
        //b = a + b * c;
        //Console.WriteLine(b);

        //int a = 4;
        //int b = 5;
        //int max = Math.Max(a, b);
        //int min = Math.Max(a, b);
        //Console.WriteLine(min);
        //Console.WriteLine(max);

        //bool isM=true;
        //bool isTu;
        //bool isW=true;
        //bool isTh;
        //bool isF;
        //bool isSat;
        //bool isSun;

        //int monday = 1;
        //int tuesday = 2;
        //int wensday = 4;
        //int thrsday = 8;
        //int friday = 16;
        //int saturday = 32;
        //int sunday = 64;

        //int day = int.Parse(Console.ReadLine());
        //switch (day)
        //{
        //    case 1:
        //        if ((day & monday) != 0)
        //        {
        //            Console.WriteLine("Alarm in monday");
        //        }
        //        break;
        //    case 2:
        //        if ((day & tuesday) != 0)
        //        {
        //            Console.WriteLine("Alarm in tuesday");
        //        }
        //        break;
        //    case 4:
        //        if ((day & wensday) != 0)
        //        {
        //            Console.WriteLine("Alarm in wensday");
        //        }
        //        break;
        //    case 8:
        //        if ((day & thrsday) != 0)
        //        {
        //            Console.WriteLine("Alarm in thrsday");
        //        }
        //        break;
        //    case 16:
        //        if ((day & friday) != 0)
        //        {
        //            Console.WriteLine("Alarm in friday");
        //        }
        //        break;
        //    case 32:
        //        if ((day & saturday) != 0)
        //        {
        //            Console.WriteLine("Alarm in saturday");
        //        }
        //        break;
        //    case 64:
        //        if ((day & sunday) != 0)
        //        {
        //            Console.WriteLine("Alarm in sunday");
        //        }
        //        break;
        //}

        //public enum Days
        //{

        //a = 1,
        //b = 1,
        //c = 1,
        //d = 1,
        //e = 1,
        //f = 1,
        //g = 1,

        //}
        //string aa = "123456789";

        //int a = 1;
        //int a1 = 1 << 1;
        //int a2 = 1 << 2;
        //int a3 = 1 << 3;
        //int a4 = 1 << 4;
        //int a5 = 1 << 5;
        //int a6 = 1 << 6;
        //int a7 = 1 << 7;
        //int a8 = 1 << 8;
        //int a9 = 1 << 9;
        //int a10 = 1 << 10;
        //int a11 = 1 << 11;
        //int a12 = 1 << 12;
        //int a13 = 1 << 13;
        //int a14 = 1 << 14;
        //int a15 = 1 << 15;
        //int a16 = 1 << 16;
        //int a17 = 1 << 17;
        //int a18 = 1 << 18;
        //int a19 = 1 << 19;
        //int a20 = 1 << 20;
        //int a21 = 1 << 21;
        //int a22 = 1 << 22;
        //int a23 = 1 << 23;
        //int a24 = 1 << 24;
        //int a25 = 1 << 25;
        //int a26 = 1 << 26;
        //int a27 = 1 << 27;
        //int a28 = 1 << 28;
        //int a29 = 1 << 29;
        //int a30 = 1 << 30;
        //int a31 = 1 << 31;
        //var busydays = a1 | a2 | a4;

        //Console.WriteLine(a3 & a3);


        //Console.WriteLine($"Are you busy in {a1},{a2},{a4} (yes/no)");
        //string busy = Console.ReadLine();
        //if (busy == "yes")
        //{
        //    Console.WriteLine("Do you have free days in the coming days?(yes/no)");
        //}
        //string yesno = Console.ReadLine();

        //if (yesno == "yes")
        //{
        //        if ((a1 & busydays) != 0)
        //        {
        //            Console.WriteLine($"{a1} is your coming free day");
        //        }

        //}


        //object a = 4;
        //int b = (int)a;
        //Console.WriteLine(b);

        //1.

        //int a = 5;
        //int b = 7;
        //int c = 1;
        //int d = 9;
        //int e = 8;
        //int max;

        //if(a > b)
        //{
        //    max = a;
        //}else
        //{
        //    max = b;
        //}
        //if(max < c)
        //{
        //    max = c;
        //}
        //else if(max < d)
        //{
        //    max = d;
        //}else if (max < e)
        //{
        //    max = e;
        //}

        //Console.WriteLine(max);

        //2.

        //var random = new Random();

        //for(int i = 0; i < 100; i++)
        //{

        //    int a = random.Next(0, 10);
        //    if (a % 2 == 0)
        //    {
        //        Console.WriteLine($"{a} zuyg");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} kent");
        //    }
        //}

        //3.

        //var random = new Random();

        //for (int i = 0; i < 100; i++)
        //{

        //    int a = random.Next(1, 10);
        //    if (a % 2 == 0)
        //    {
        //        Console.WriteLine($"{a} zuyg");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} kent");
        //        i = 101;
        //    }
        //}

        //4.

        //var random = new Random();
        //int max1 = 0;
        //int max2 = 0;
        //int max3 = 0;

        //for (int i = 0; i < 100; i++)
        //{
        //    int a = random.Next(1, 10);
        //    if (a > max1)
        //    {
        //        max3 = max2;
        //        max2 = max1;
        //        max1 = a;
        //    }

        //    else if (a > max2 && a <= max1)
        //    {
        //        max3 = max2;
        //        max2 = a;

        //    }
        //    else if (a > max3 && a <= max2 && a <= max1)
        //    {
        //        max3 = a;

        //    }
        //    Console.WriteLine(a);

        //}
        //Console.WriteLine($"max {max1} {max2} {max3}");
        //Console.WriteLine($"sum = {max1 + max2 + max3}");

        //5.

        var random = new Random();
        int max1 = 0;
        int max2 = 0;
        int min1 = 10;
        int min2 = 0;

        for (int i = 0; i < 5; i++)
        {

            int a = random.Next(1, 10);
            if (a > max1)
            {
                max2 = max1;
                max1 = a;

            }
            else if (a > max2 && a <= max1)
            {
                max2 = a;
                Console.WriteLine($"max2 {max2}");
            }
            if (a < min1)
            {
                min2 = min1;
                min1 = a;
            }
            else if (a < min2)
            {
                min2 = a;
            }

            Console.WriteLine(a);
        }
        float median = (float)(max1 + max2 + min1 + min2) / 4;
        Console.WriteLine($"max {max1} {max2}");
        Console.WriteLine($"min {min1} {min2}");
        Console.WriteLine(median);

       
        
    }
}
