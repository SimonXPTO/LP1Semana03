using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere uma string: ");
            string s = Console.ReadLine();
            Console.Write("Insere um caráter: ");
            string b = Console.ReadLine();
            char c= char.Parse(b);
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i]== c)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
