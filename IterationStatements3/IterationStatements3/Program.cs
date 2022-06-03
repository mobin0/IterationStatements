using System;

namespace IterationStatements3
{
    internal class Program
    {

        static void printLoop5() {
            Console.WriteLine("Printing 5!");
        for (int i = 0; i <5; i++){
            Console.WriteLine($"{i}");
            }
        
        }
        static void printThousands() {
            ;
            for (int i = 1000; i >= -1000; i--) {
                Console.WriteLine(i);
            }
        
        }
        static void printby3()
        {
            Console.WriteLine("Printing 3s");
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }

        }

        static string Equal(int a, int b) {
            string result = a == b ? $"{a} is equal to {b} indeed" : $"{a} is not equal to {b}, indeed";
            Console.WriteLine(result);
            return result;
        
        
        }

        static string isEven(int a)
        {
            string result = a %2 == 0 ? $"{a} is even" : $"{a} is not even";
            Console.WriteLine(result);
            return result;


        }


        static string isPositive()

        {
            Console.WriteLine("Please enter your number to check if it is Positive or Negative!");

            var a = Console.ReadLine();
            bool e = float.TryParse(a, out float b);
            string result;
            if (e == false) {
                return "Can't read {a}";
                    }
            if (b == 0) {
                result = "Neither, it is 0!!";
                Console.WriteLine(result);
                return result;
            }
            result = b > 0 ? $"{a} is positive" :$"{a} is negative";
            Console.WriteLine(result);
            return result;


        }

        static string canVote()
        {
            Console.WriteLine("Please enter your number to age to see if you can vote!");

            var a = Console.ReadLine();
            bool e = float.TryParse(a, out float b);
            string result;
            if (e == false) {
                return "Can't read {a}";
                    }
            if (b == 0) {
                result = "You have just been born, so please wait a few years";
                Console.WriteLine(result);
                return result;
            }
            result = b >= 18 ? $"{b} years is eligible to Vote!" :$"{b} is not Eligible to Vote!";
            Console.WriteLine(result);
            return result;


        }

        static string inRangeofTens()
        {
            Console.WriteLine("Please enter your number to see if it is in the range of 10 and -10!");

            var a = Console.ReadLine();
            bool e = float.TryParse(a, out float b);
            string result;
            if (e == false)
            {
                return "Can't read {a}";
            }
            result = b <= 10 && b >= -10 ? $"{b} is in the range!" : $"{b} is in not the range!";
            Console.WriteLine(result);
            return result;


        }


        static void multiplicationTable12()
        {
            Console.WriteLine("Please enter your number to see its multiplication table till 12!");

            var a = Console.ReadLine();
            bool e = float.TryParse(a, out float b);
            if (e == false)
            {
                Console.WriteLine("Can't read {a}");
            }
            for (int x = 1; x <= 12; x++) {
                Console.WriteLine($"{b} x {x} is {x * b}");
            }




        }

        static void Main(string[] args)
        {
            printLoop5();
            printThousands();
            Equal(5, 6);
            /* try the number 0, and 3.14159*/
            isPositive();
            canVote();
            inRangeofTens();
            multiplicationTable12();


        }
    }
}
