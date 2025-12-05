namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1 (Find max)

            int[] numbers = new int[] {0,1,2,3,4,5,6,7,8,9};
            int max = 0;
            for(int i = 0;i < numbers.Length; i++)
            {
               if (numbers[i] > max)
               {
                   max = numbers[i];
               }
            }
            Console.WriteLine(max);

            // Task 2 (Reverse array)

            string[] names = { "name1", "name2", "name3", "name4", "name5" };
            string[] names2 = new string[5];
            int a = 0;
            for (int i = names.Length - 1; i >= 0; i--)
            {
               names2[a] = names[i];
               a++;
            }
            for(int i = 0; i < names2.Length; i++)
            {
               Console.WriteLine(names2[i]);
            }

            // Task 3 (Average score)

            double[] scores = { 4, 5, 5, 4, 3, 5, 3 };
            double sum = 0;
            for(int i = 0; i < scores.Length; i++)
            {
               sum = sum + scores[i];
            }
            double average = sum / scores.Length;
            Console.WriteLine(average);

            // Task 4 (Count even/odd)

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
               if (numbers[i] % 2 == 0)
               {
                   even = even + 1;
               }
               else
               {
                   odd = odd + 1;
               }
            }
            Console.WriteLine($"Even {even}, odd {odd}");

            // Task 5 (Search fruit)

            string[] fruits = { "Apple", "Banana", "Strawberry", "Mango", "Watermelon" };
            Console.WriteLine("Enter fruit name");
            string name = Console.ReadLine();
            if(Array.IndexOf(fruits, name) >= 0 && Array.IndexOf(fruits, name) <= 4)
            {
               Console.WriteLine($"{name} found");
            }
            else
            {
               Console.WriteLine($"{name} not found");
            }

            // Task 6 (Bubble sort)

            int[] numbers = { 8, 1, 5, 2, 9, 7, 3, 4, 6 };
            int a;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
               for(int j = 0; j < numbers.Length - 1; j++)
               {
                   if (numbers[j] > numbers[j + 1])
                   {
                       a = numbers[j];
                       numbers[j] = numbers[j + 1];
                       numbers[j + 1] = a;
                   }
               }
            }
            for(int i = 0;i < numbers.Length; i++)
            {
               Console.WriteLine(numbers[i]);
            }

            // Task 7 (Sum numbers)

            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for(int i = 0;i < numbers.Length; i++)
            {
               sum = sum + numbers[i];
            }
            Console.WriteLine(sum);

            // Task 8 (Copy array)

            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[5];

            for (int i = 0;i < numbers.Length; i++)
            {
               numbers2[i] = numbers[i];
            }
            for(int i = 0;i < numbers2.Length; i++)
            {
               Console.WriteLine(numbers2[i]);
            }

            // Task 9 (Combine firstname + lastname)

            string[] firstname = { "firstname1", "firstname2", "firstname3", "firstname4" };
            string[] lastname = { "lastname1", "lastname2", "lastname3", "lastname4" };

            for(int i = 0; i < firstname.Length; i++)
            {
               Console.WriteLine($"{firstname[i]} {lastname[i]}");
            }

            // Task 10 (Count occurrences)

int[] numbers = { 5, 1, 2, 2, 3, 5, 3, 3, 4, 4, 4, 4, 5, 5, 0, 0, 0, 0, 9, 10, 14, 15};
int[] numbers2 = { };
int count = 0;
int a = 0;
bool contains = false;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers2.Length; j++)
    {
        if (numbers[i] == numbers2[j])
        {
            contains = true;
            break;
        }
    }
    if (!contains)
    {
        Array.Resize(ref numbers2, numbers2.Length + 1);
        numbers2[a] = numbers[i];
        a++;
    }

    contains = false;
}

for (int i = 0; i < numbers2.Length; i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers2[i] == numbers[j])     
        {
            count++;
        }
    }

    Console.WriteLine($"{numbers2[i]} appeared {count} times");
    count = 0;
                                                
}
            
            // Other tasks
            
            // 1.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[5];
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}
            //Console.WriteLine("");
            //Array.Copy(numbers, numbers2, 5);
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            
            // 2.
            //var zooq1 = new Zoo();
            ////zoo.Animals[0] = "Lion";
            //Console.WriteLine(zoo.Name);
            //Console.WriteLine(zoo.Year);
            
            //var animals = new Animal();
            //animals.Name = "Lion";
            //animals.Gender = "Male";
            //animals.Age = 1;
            //Console.WriteLine(animals.Name);
            //Console.WriteLine(animals.Gender);
            //Console.WriteLine(animals.Age);
            
        }
    }
    //struct Zoo
    //{
    //    public string? Name { get; }
    //    public int? Year { get; }
    //    public Animal[] Animals { get; set; }

    //    public Zoo(string name,int year, Animal[] animals)
    //    {
    //        Name = name;
    //        Year = 2025;
    //        Animals = animals;
    //    }
    //    public Zoo()
    //    {

    //    }


    //}
    //struct Animal
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public int Age { get; set; }
    //    public Animal()
    //    {
          
    //    }
    //    public Animal(string name,string gender, int age)
    //    {
    //        Name = name;
    //        Gender = gender;
    //        Age = age;
    //    }

    }
}



