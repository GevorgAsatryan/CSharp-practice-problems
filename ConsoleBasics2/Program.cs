namespace ConsoleBasics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Version 1.(manually)

            Console.WriteLine("Hi.Enter 8 letter word.");
            string word = Console.ReadLine();
            Console.Write(word[7]);
            Console.Write(word[6]);
            Console.Write(word[5]);
            Console.Write(word[4]);
            Console.Write(word[3]);
            Console.Write(word[2]);
            Console.Write(word[1]);
            Console.Write(word[0]);

            //Version 2.

            Console.WriteLine("Hi.Enter 8 letter word.");
            string word1 = Console.ReadLine();

            for (int i = word1.Length - 1; i >= 0; i--)
            {
                Console.Write(word1[i]);
            }

            //Task 2

            Console.WriteLine("Enter any word you want");
            string word = Console.ReadLine();
            char firstletter = word[0];
            char lastletter = word[word.Length - 1];
            char winner;
            if (firstletter > lastletter)
            {
                winner = lastletter;
            }
            else
            {
                winner = firstletter;
            }
            Console.WriteLine($"Between {firstletter} and {lastletter},{winner} wins!");

            //Task 3

            Console.WriteLine("Enter your favorite color");
            string color = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine($"{color} {animal}");

            //Task 4

            Console.WriteLine("Enter 6 letter word");
            string word = Console.ReadLine();
            char letter1 = word[1];
            char letter2 = word[3];
            char letter3 = word[5];

            Console.WriteLine($"{letter1}{letter2}{letter3}");

            //Task 5

            Console.WriteLine("Enter 2 letters to know the distance between them.");
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();

            int char1 = w1[0];
            int char2 = w2[0];

            Console.WriteLine(char2 - char1);

            //Task 6

            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            string uppercase = word.ToUpper();
            string lowercase = word.ToLower();
            Console.WriteLine(uppercase + lowercase);

            //Task 7

            Console.WriteLine("Write a word.");
            string word = Console.ReadLine();
            int word1 = (word.Length) / 2;
            int word2 = word.Length;
            for (int i = 0; i < word1; i++)
            {
                Console.Write(word[i]);

            }
            Console.WriteLine();
            for (int e = word1; e < word2; e++)
            {
                Console.Write(word[e]);
            }

            //Task 8
            //Version 1(only 4 letters)

            Console.WriteLine("Write 4 letter word");
            string word4 = Console.ReadLine();
            Console.WriteLine($"{word4[word4.Length - 1]}{word4[1]}{word4[2]}{word4[0]}");

            //Version 2

            Console.WriteLine("Write a word");
            string newword = null;
            for (int i = 1; i < word4.Length - 1; i++)
            {

                newword += word4[i];

            }
            Console.Write($"{word4[word4.Length - 1]}{newword}{word4[0]}");

            //Task 9

            Console.WriteLine("Write 2 letters");
            char first = Console.ReadLine()[0];
            char second = Console.ReadLine()[0];

            int a = first;
            int b = second;
            int difference = b - a;

            Console.WriteLine($"{first}:{a},{second}:{b},Difference:{difference}");

            //Bonus Challenges
            //1.

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            //2.
            Console.WriteLine();
            Console.WriteLine("Enter fruit name.");
            string fruit = Console.ReadLine();
            char middle = fruit[fruit.Length / 2];
            Console.WriteLine(middle);
            //3.
            Console.WriteLine("Enter 5 letter word");
            string letter5 = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <= letter5.Length - 1; i++)
            {
                sum += letter5[i];
            }
            Console.WriteLine(sum);
            //4.
            Console.WriteLine("Enter 2 words.");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            Console.WriteLine($"{word1}-{word2}");

            //5.
            Console.WriteLine("Enter your birth month.");
            string month = Console.ReadLine();
            Console.WriteLine("Enter your birth day.");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine($"{day} {month}");
            int i = 0;
            int student = 1;
            Console.WriteLine("How many times to enter?");
            int s = int.Parse(Console.ReadLine());
            while (i < s)
            {
                Console.WriteLine($"Student {student}");
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Profession");
                string surname = Console.ReadLine();
                i++;
                student++;

            }
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                Console.WriteLine("Would you like to exit from cycle?(yes or no)");
                string yesno = Console.ReadLine().ToLower();
                if (yesno == "yes")
                {
                    number -= number;
                }
                else
                {
                    sum += number;
                    number--;
                }

            }
            Console.WriteLine(sum);

        }
    }
}
