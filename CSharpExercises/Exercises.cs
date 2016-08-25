using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        private static int i;

        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b)
        {
            return a + b; 
        }

        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(int a, int b)
        {
            return a / b; 
        }

        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }


        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            var names = fullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];
            return firstName;

        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string reverse)
        {
            string input = reverse;
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }



        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string x)
        {
            char[] cArray = x.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }


        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int number)
        {
            //creat the empty "table" string variable to hold the times table.
            string table = "";
            // Now, create a loop to iterate over the 9th multiplication, all the way to, but not including 10.
            for (int i = 1; i <= 9; i++)
            {
            table += number + " * " + i + " = " + (number * i) + "\r\n";
            }
            table += number + " * " + 10 + " = " + (number * 10);
            return table;

        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            // Simple mathematic equation converting kelvins to fahrenheit using [ F = 9/5(kelvin - 273) + 32]
            double fahrenheit = (9d/5d * (kelvin - 273.15d) + 32d);
            return fahrenheit = Math.Round(fahrenheit, 2);
              
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] avg)
        {
            // the starting value of the total amount of numbers in the array.
            double sum = 0; 
            // The foreach loop will allow the function to look at the int number in the values array.
            // example of a for loop: for(int i = 0; i < avg.Length; i++)
            foreach (int number in avg)
            {
                sum += number;
            }
            //Now, take the sum of the avg array, by taking the total length and dividing it by the total in the index, and then add that to the total average.
            sum /= avg.Length;
            return sum;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] avg)
        {
            return avg.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
        // Create an empty string for the output of the for loop function, to be inputted.
            string returnString = "";
            // Create a for loop that iterates down the list for the width. In this example, i = width, and considering that a negative int is not able to fill a spot in that width, i needs to be >= 0. As the for loop is repeated, the next line needs to subtract 1 section of the width.(i--).
            for (var i = width; i >= 0; i--)
            {
                // Create another for loop within the existing loop to allow the number itself, to represent the max number of sections in the width. {ex. number is 5. max width sections is 5}
                for (var x = i; x >= 1; x--)
                {
                    returnString += number.ToString();
                }
                if (i >= 2)
                {
                    returnString += System.Environment.NewLine;
                }
               
            } return returnString;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char abc)
        {
        // Create an if statement to represent that the char abc needs to equal the vowel characters: a,e,i,o,u; in order to be true.
            if (abc == 'a' || abc == 'e' || abc == 'i' || abc == 'o' || abc == 'u')
            {
                return true;
            }
            else
        // Return false, if the character is not equal to a vowel.
            {
                return false;
            }
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char con)
        {
            return !IsVowel(con);
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}