using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Math
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first integer?");
            int
        }

        //this method will take the user's input and confirm that they gave us and integer
        // if they didn't it will return the int 0
        public int validateInput(string input)
        {
            int validated = 0;

            bool success = int.TryParse(input, out validated);

            return validated;
        }

        //recursive method that takes in the number to recursively add the least significant number to itself, once you've removed the least significant number
        public int recursiveMethod(int bigNum)
        {
            //this makes sure we aren't done. It will exit if the int is a single digit
            if(bigNum == bigNum % 10) 
            {
                return bigNum;
            }
            else
            {

            }
            
        }
    }

}
