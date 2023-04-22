using System;

namespace Codeforces_4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int len = word.Length;
            if (len>10 && word.All(char.IsDigit) == false)
            {
                len -= 2;
                Console.WriteLine(word[0] + len + word[-1]);
            }else if (word.All(char.IsDigit) == true)
            {
    
            }else if (len<10 && word.All(char.IsDigit) == false)
            {
                Console.WriteLine(word);
            }
        }
    }
}
