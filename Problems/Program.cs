using System;

namespace Problems
{
    public class Program
    {
        public static string Prefix(string input)
        {

            if (input.Equals(null))
            {
                return null;
            }

            string str = input; //variable creation
            int length;
            int nwords = 0;
            int spaces = 0;

            
            string[] wordlist = input.Split(' '); //splits the input on the spaces
            foreach (string x in wordlist)
            {
                
                nwords += 1;
                
                if(wordlist.Length == 0)
                {
                    nwords = 0;
                }
            }
            
            length = input.Length; //string length
            
            str = length.ToString() + "," + nwords.ToString() + ":" + str ;

            return str;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Prefix("hello"));
            Console.WriteLine(Prefix(""));
            Console.WriteLine(Prefix("what ... did you say??"));
        }
    }
}

