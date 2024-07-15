namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeToNineNine()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static int? AcceptNum(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} equals to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} do not equal each other");
            }
            return null;
        }
        //Write a method to check whether a given number is even or odd
        public static string? EvenOrOdd(int num)
        {
            var result = num % 2 == 0 ? $"{num} is even" : $"{num} is odd";
            Console.WriteLine(result);
            return null;
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int number)
        {
            var userInput = number >= 0 ? $"{number} is positive number" : $"{number} is negative number";
            Console.WriteLine(userInput);
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static int OverAge()
        {
            int userAge;
            
            do
            {
                Console.WriteLine("How old are you?");
                userAge = Convert.ToInt32(Console.ReadLine());

                if (userAge >= 18)
                {
                    Console.WriteLine("You are eligible to vote");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote try again");
                }
                
            } while (userAge < 18);

            return userAge;
        }
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()

            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10
            public static int? CheckInt()
            {
                Console.WriteLine("Pick a number from -10 to 10");
                int userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum >= -10 && userNum <= 10)
                {
                    Console.WriteLine("Number is in range");
                }
                else
                {
                    Console.WriteLine("Number is not in range");
                }

                return null;
            }
            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            public static int? MultTable()
            {
                Console.WriteLine("Enter a number to multiply it by");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int i = 1; i <= 12; i++)
                {
                    int result = number * i;
                    Console.WriteLine(result);
                }

                return null;
            }

            //Call the methods to test them in the Main method below
        
    

    static void Main(string[] args)
        {
            NumThousand();
            Console.WriteLine();
            ThreeToNineNine();
            Console.WriteLine();
            
            Console.WriteLine("Enter Number 1 to see if it equals the second number");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 to see if it equals to the first number");
            var num2 = Convert.ToInt32(Console.ReadLine());
            AcceptNum(num1,num2);
            
            Console.WriteLine();
            Console.WriteLine("Enter a number to see whenever it is even or odd");
            var num = Convert.ToInt32(Console.ReadLine());
            EvenOrOdd(num);
            
            Console.WriteLine();
            Console.WriteLine("Enter a number to see if it is positive or negative");
            var number = Convert.ToInt32(Console.ReadLine());
            PositiveOrNegative(number);

            OverAge();
            CheckInt();
            MultTable();


        }
    }
}
