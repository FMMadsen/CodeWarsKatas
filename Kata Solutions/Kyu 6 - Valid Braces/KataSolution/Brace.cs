namespace KataSolution
{
    using System;
    using System.Collections.Generic;

    public class Brace
    {
        /// <summary>
        /// Valid braces: ()[]{}
        /// 
        /// true:  "()"
        /// true:  "(){}[]"
        /// true:  "([{}])"
        /// false: "(}"
        /// false: "[(])"
        /// false: "[({})](]"
        /// false: "})]"
        /// false: "(((({{"
        /// 
        /// </summary>
        public static bool validBraces(String braces)
        {
            Stack<char> bStack = new Stack<char>();

            foreach (char c in braces)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        bStack.Push(c);
                        break;
                    case ')':
                        if (bStack.Count == 0 || bStack.Pop() != '(')
                            return false;
                        break;
                    case ']':
                        if (bStack.Count == 0 || bStack.Pop() != '[')
                            return false;
                        break;
                    case '}':
                        if (bStack.Count == 0 || bStack.Pop() != '{')
                            return false;
                        break;
                    default:
                        return false;

                }
            }

            return bStack.Count == 0;
        }
    }
}
