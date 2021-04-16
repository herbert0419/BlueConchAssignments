using System;
using System.Collections.Generic;
using System.Linq;



namespace BalancedConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string testString = Console.ReadLine();
            Console.WriteLine(CheckBalanced(testString));
        }

        //If current char in the teststring is an opening brace, push it in the stack
        //If current char in the teststring is a closing brace, pop a char from the stack, and return false if the popped char not match with its respective opening brace

        public static bool CheckBalanced(string check)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < check.Length; i++)
            {
                char character = check[i];
                if (character == '[' || character == '{' || character == '(')
                    stack.Push(character);
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (!stack.Any()) // if stack is empty and you have a closing character this means that it is unbalanced 
                        return false;
                    switch (character)
                    {
                        case ']':
                            if (stack.Pop() != '[')
                                return false;
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                                return false;
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                                return false;
                            break;
                        default:
                            break;
                    }
                }
            }
            // it is balanced only if there aren't any left
            if (!stack.Any())
                return true;
            return false;
        }
    }
}
