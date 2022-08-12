using System;

namespace StoryMethod

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How tall are you in feet?");
            string userHeight = Console.ReadLine();

            Console.WriteLine("What is your birthstone?");
            string userStone = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your lucky number?");
            string userNumber = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();

            Console.WriteLine($"You enter a cave on the side of a mountain that is taller than {userHeight}.");
            Console.WriteLine($"When you enter the cave, you see a {userStone} amulet sitting in a {userColor} box.");
            Console.WriteLine($"Falling prey to temptation, you put the amulet on and notice {userNumber} red, glowing eyes staring at you.");
            Console.WriteLine($"As you take a closer look, you realize the eyes belong to the ghost of a {userAnimal}.");
            Console.WriteLine($"Filled with terror, you rip the amulet off and escape the mountain with a promise to return {userAge} years later.");

            Console.WriteLine("Give me your birth date.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me your birth year.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"You gained {sum} experience points.");

            Console.WriteLine("Give me the year you graduated high school.");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me your shoe size.");
            int num4 = int.Parse(Console.ReadLine());

            int Product = Multiply(num3, num4);
            Console.WriteLine($"You collected {Product} coins.");

            int diff = Subtract(num1, num4);
            Console.WriteLine($"Your health bar increased by {diff}.");

            int split = Divide(num2, num1);
            Console.WriteLine($"Your stamina bar increased by {split}.");

            int remainder = Modulus(num2, num1 - split);
            Console.WriteLine($"Because you escaped undetected, you took {remainder} damage.");
            

        }


        public static int Sum(int num1, int num2)
        {
            return num1 + num2; 
        }



        public static int Multiply(int x, int y)
        {
            return x * y;
        }




        public static int Subtract(int num1, int num4)
        {
            return num1 - num4; 
        }
        



        public static int Divide(int num2, int num1)
        {
            return num2 / num1;
        }



   

        public static int Modulus(int num2, int num1)
        {
            return num2 / num1; 
        }
    }
}
