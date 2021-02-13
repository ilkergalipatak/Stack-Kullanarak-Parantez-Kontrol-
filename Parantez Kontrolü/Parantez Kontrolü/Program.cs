using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parantez_Kontrolü
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bracketControl("((1+2)+[4+5]{7*8}}]"));
            Console.ReadLine();
        }
        private static bool bracketControl(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in text)
            {
                if (c=='{'||c=='['||c=='(')
                {
                    stack.Push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (stack.Count <= 0)
                    {
                        return false;
                    }
                    char open = stack.Pop();
                    if (c == '}' && open != '{' || c == ']' && open != '[' || c == '(' && open != ')')
                    {
                        return false;
                    }
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
