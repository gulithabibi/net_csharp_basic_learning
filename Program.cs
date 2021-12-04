using System;
using System.Linq;

namespace netcore_csharp_basic_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is commentad
            //Test running hello world
            Console.WriteLine("Hello World!");

            Variable();

        }


        public static void Variable()
        {
            string name = "Gulit Habibi";
            int myNum = 15;
            myNum = 20;//myNum is now 20

            const int myNum2 = 35;
            //Num2=40 //will get error, becasue const can't update value

            Console.WriteLine(name);
        }

        public static void DataType()
        {
            int myNume = 5;//Integer(whole number)
            double myDouble = 24.7;//Floating point number
            char myChar = 'G';//charcter
            bool myBool = true;// Boolean
            string myString = "Gulit"; //String

            Console.WriteLine(myString);
        }

        public static void type_casting()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        public static void user_input()
        {
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
        }

        public static void Operators()
        {
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
        }

        public static void Mathematic()
        {
            int max = Math.Max(5, 10);          //The Math.Max(x,y) method can be used to find the highest value of x and y:
            int min = Math.Min(5, 10);          //The Math.Min(x,y) method can be used to find the lowest value of of x and y:
            double sqrt = Math.Sqrt(64);        //The Math.Sqrt(x) method returns the square root of x:
            double abs = Math.Abs(-4.7);        //The Math.Abs(x) method returns the absolute (positive) value of x:
            double rounbd = Math.Round(9.99);   //Math.Round() rounds a number to the nearest whole number:
        }

        public static void StringOp()
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            string name2 = string.Concat(firstName, lastName);
            string name3 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"


            // Full name
            string fullname = "John Doe";
            // Location of the letter D
            int charPos = fullname.IndexOf("D");

            // Get last name
            lastName = fullname.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }

        public static void IfElse()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
        }

        public static void SwitchOp()
        {
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."
        }

        public static void WhileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
        }

        public static void ForLoop()
        {
            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }


        public static void BreakContinue()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }

            int j = 0;
            while (j < 10)
            {
                if (j == 4)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }
        }

        public static void ArrayOp()
        {
            // Declare an array
            string[] fruits;
            // Add values, using new
            fruits = new string[] { "Apple", "Mango", "Banana" };
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            // Now outputs Opel instead of Volvo

            Console.WriteLine(cars.Length);
            // Outputs 4

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Array.Sort(cars);

            //// Create an array of four elements, and add values later
            //string[] cars = new string[4];

            //// Create an array of four elements and add values right away 
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            //// Create an array of four elements without specifying the size 
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            //// Create an array of four elements, omitting the new keyword, and without specifying the size
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };


            int[] myNum = { 10, 20, 30, 40 };
            Console.WriteLine(myNum.Max());  // returns the largest value
            Console.WriteLine(myNum.Min());  // returns the smallest value
            Console.WriteLine(myNum.Sum());  // returns the sum of elements

        }

    }
}
