using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    class Program
    {

        private static string inputValue = "";
        private static string RPNCalc(string rpnValue)
        {
            Stack<int> stackCreated = new Stack<int>();
            stackCreated.Clear();
            string[] inputArray = rpnValue.Split();
            int end = inputArray.Length - 1;
            int numInput;
            int i = 0;

            do
            {
                if ("=+-*/%^".IndexOf(inputArray[i]) == -1)
                {
                    try
                    {
                        numInput = Convert.ToInt32(inputArray[i]);
                        stackCreated.Push(numInput);
                    }
                    catch
                    {
                        return "wrong operator";
                    }
                }

                else if (inputArray[i] == "+")
                {
                    try
                    {
                        int store1 = stackCreated.Pop();
                        int store2 = stackCreated.Pop();
                        stackCreated.Push(store2 + store1);
                    }
                    catch
                    {
                    }
                }

                else if (inputArray[i] == "-")
                {
                    try
                    {
                        int store1 = stackCreated.Pop();
                        int store2 = stackCreated.Pop();
                        stackCreated.Push(store2 - store1);
                    }
                    catch
                    {
                    }
                }

                else if (inputArray[i] == "%")
                {
                    try
                    {
                        int store1 = stackCreated.Pop();
                        int store2 = stackCreated.Pop();
                        stackCreated.Push(store2 % store1);
                    }
                    catch
                    {
                    }
                }

                else if (inputArray[i] == "*")
                {
                    try
                    {
                        int store1 = stackCreated.Pop();
                        int store2 = stackCreated.Pop();
                        stackCreated.Push(store2 * store1);
                    }
                    catch
                    {
                    }
                }

                else if (inputArray[i] == "/")
                {
                    try
                    {
                        int store1 = stackCreated.Pop();
                        int store2 = stackCreated.Pop();
                        stackCreated.Push(store2 / store1);
                    }
                    catch
                    {
                    }
                }

                else if (inputArray[i] == "^")
                {
                    try
                    {
                        int store1 = stackCreated.Pop();
                        int store2 = stackCreated.Pop();
                        stackCreated.Push((int)Math.Pow(store1, store2));
                    }
                    catch
                    {
                    }
                }

            }
            while (i++ < end && inputArray[i] != "=" && stackCreated.Count != 0);
            string result = inputValue + " " + stackCreated.Pop().ToString() + Environment.NewLine;

            return result;

        }
        static void Main(string[] args)
        {
            string str = "4 5 + 2 1 + *";
            //string str = "1 1 + 1 + 1 +"
            Console.WriteLine(RPNCalc(str));
            Console.ReadLine();
        }
    }
}
