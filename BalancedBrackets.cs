using System;
namespace BalancedBrackets
{
	public class BalancedBrackets
	{
        /**
         * The function HasBalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets: 5
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not: 4
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */

        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (brackets >= 0)
                {
                    if (ch == '[')
                    {
                        brackets++;
                    }
                    else if (ch == ']')
                    {
                        brackets--;
                    }
                }
            }
            return brackets == 0;
        }
    }
}

