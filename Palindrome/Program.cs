using System;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HavePalindrome(args);
        }

        public static void HavePalindrome(params string[] _words)
        {
            bool IsPalindrome(string _word)
            {
                if (_word == default)
                    throw new ArgumentNullException();
                if (_word.Length < 2)
                    return true;

                string _wordInverted = reverse(_word);

                if (_word == _wordInverted)
                    return true;
                else
                    return false;
            }

            foreach (string _word in _words)
            {
                Console.WriteLine($"{_word} -> {IsPalindrome(_word)}");
            }
        }

        public static string reverse(string s) 
        {
            string r = "";
            for (int i = s.Length; i > 0; i--) r += s[i - 1];
            return r;
        }
    }
}

