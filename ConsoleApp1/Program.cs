// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        // 1.
        
           Console.WriteLine("Enter your age.");
           int age = int.Parse(Console.ReadLine());
           if(age > 21)
           {
               Console.WriteLine("Is citizen");
           }
           if(age < 18)
           {
               Console.WriteLine("Isn't citizen");
           }
           if(age > 18)
           {
               Console.WriteLine("Where are you from?");
           }
           string country = Console.ReadLine();
           if (country == "Armenia")
           {
               Console.WriteLine("Is Armenian");
           }
           if(country == "USA")
           {
               Console.WriteLine("Is citizen of USA");
           }
        
        // 2.
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = 0;
        if (a > b)
        {
           max = b;
        }
        if(a < b)
        {
           max = b;
        }
        if(c > max)
        {
           max = c;
        }
        Console.WriteLine(max);
        
        // 3.
        
        Console.WriteLine("Name");
        string name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Where are you from?");
        string country = Console.ReadLine().ToLower();
        Console.WriteLine("Do you have id (yes/no)");
        string id = Console.ReadLine().ToLower();
        string adult = null;
        string citizen = null;
        if(age < 18)
        {
           adult = "not adult";
        }
        if (id == "yes")
        {
           if (age >= 18 && country == "armenia")
           {

               adult = "adult";
               citizen = "Armenia";

           }

           if (age >= 21 && country == "usa")
           {

               adult = "adult";
               citizen = "USA";

           }
        }
        if(id == "no")
        {
           adult = "not adult";
        }
        Console.WriteLine($"Name:{name},Age:{age},Citizen:{citizen},{adult}");

        
        

        // 1.

        int a = 5;
        int b = 7;
        int c = 1;
        int d = 9;
        int e = 8;
        int max;

        if(a > b)
        {
           max = a;
        }else
        {
           max = b;
        }
        if(max < c)
        {
           max = c;
        }
        else if(max < d)
        {
           max = d;
        }else if (max < e)
        {
           max = e;
        }

        Console.WriteLine(max);

        //2.

        var random = new Random();

        for(int i = 0; i < 100; i++)
        {

           int a = random.Next(0, 10);
           if (a % 2 == 0)
           {
               Console.WriteLine($"{a} zuyg");
           }
           else
           {
               Console.WriteLine($"{a} kent");
           }
        }

        //3.

        var random = new Random();
        int max1 = 0;
        int max2 = 0;
        int max3 = 0;

        for (int i = 0; i < 100; i++)
        {
           int a = random.Next(1, 10);
           if (a > max1)
           {
               max3 = max2;
               max2 = max1;
               max1 = a;
           }
           else if (a > max2 && a <= max1)
           {
               max3 = max2;
               max2 = a;
           }
           else if (a > max3 && a <= max2 && a <= max1)
           {
               max3 = a;

           }
           Console.WriteLine(a);

        }
        Console.WriteLine($"max {max1} {max2} {max3}");
        Console.WriteLine($"sum = {max1 + max2 + max3}");

        // 4.

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
        float mean = (float)(max1 + max2 + min1 + min2) / 4;
        Console.WriteLine($"max {max1} {max2}");
        Console.WriteLine($"min {min1} {min2}");
        Console.WriteLine(mean);


        
        // Other tasks and experiments
        
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

        
    }
}
