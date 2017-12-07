using System;

namespace lispy
{
    public class Tokenizer
    {
        public string[] Tokenize(string input)
        {
            return input.Replace("(", " ( ").Replace(")", " ) ").Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}