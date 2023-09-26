using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

namespace Math
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            int numOne = 0;
            int numTwo = 0;
            for (int i = 0; i < 3; i++)
            {
                if (numOne == 0)
                {
                    Console.WriteLine("What is your first integer?");
                    string StringNumOne = Console.ReadLine();
                    numOne = validateInput(StringNumOne);
                }

            }
            if (numOne == 0)
            {
                Console.WriteLine("Invalid Input Too Many Times. BYE!");
                Console.Read();
                //    Environment.Exit(0);

            }
            else
            {
                //only continue asking for data if the first integer was correctly given. 
                if (numOne != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (numTwo == 0)
                        {
                            Console.WriteLine("What is your second integer?");
                            string StringNumTwo = Console.ReadLine();
                            numTwo = validateInput(StringNumTwo);
                        }

                    }
                    //program ends if second int was not given after three attempts
                    if (numTwo == 0)
                    {
                        Console.WriteLine("Invalid Input Too Many Times. BYE!");
                        Console.Read();
                        //       Environment.Exit(0);

                    }
                    else
                    {
                        int bigNum = numOne + numTwo;
                        Console.WriteLine("\nResult: " + recursiveMethod(bigNum));
                    }
                }
           
            }

  


        }

        //this method will take the user's input and confirm that they gave us and integer
        // if they didn't it will return the int 0
        public static int validateInput(string input)
        {
            int validated = 0;

            bool success = int.TryParse(input, out validated);

            if (validated < 0)
            {
                return 0;
            }

            return validated;
        }

        //recursive method that takes in the number to recursively add the least significant number to itself, once you've removed the least significant number
        public static int recursiveMethod(int bigNum)
        {
            //this makes sure we aren't done. It will exit if the int is a single digit
            if(bigNum != bigNum % 10) 
            {
                int moddedNum = bigNum % 10; //get the least sig dig
                int divNum = bigNum / 10; //get number without least sig dig
                int newNum = divNum + moddedNum;
                return recursiveMethod(newNum);
            }
            else
            { return bigNum; }  

            
        }
    }

}
