using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = findSumOfEvenDigits(123456);

            Console.WriteLine($"result = {result}");

            Console.WriteLine(RemoveDuplicatedChar("aVarssharA"));

            //someFunc();

            int i = 10;
            dynamic y = i; //int
            // string z = y;

            Console.ReadLine();
        }

        //write a function for sum of digits all positive integers
        // 123456 -> 12; 214365 -> 12

        static int findSumOfEvenDigits (int number)
        {
            int sum = 0;

            while(number!= 0)
            {
                int quotient = number % 10;
                number = number / 10;
                if(quotient%2 == 0)
                {
                    sum += quotient;
                }
            }

            return sum;
        }

        //Varsha - Varsh

        static string RemoveDuplicatedChar(string str)
        {
            string result = "";
            //visitedCharacters
            //V, a, r s h 

            var distinctCharsArray = str.ToCharArray().Distinct().ToArray();

            var charArray = str.ToCharArray();
            var temp = charArray.Distinct().ToArray();

            result = new string(temp);

            return result;
        }

        static void someFunc() {
            var values = new List<int>() { 1, 2, 3, 4 };

            var funcs = new List<Func<int>>();

            foreach (var v in values)
                funcs.Add(() => v);

            foreach (var f in funcs)
                Console.WriteLine(f());//output 
        }



        public class Program1
        {
            public static void Main1(string[] args)
            {
                var values = new List<int>() { 1, 2, 3, 4 };

                var funcs = new List<Func<int>>();

                foreach (var v in values)
                    funcs.Add(() => v);

                foreach (var f in funcs)
                    Console.WriteLine(f());//output 
                //1
                //2
                //3
                //4
            }
        }

    }
}
