using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0228lab
{
    class Program
    {
        public static void ToCountWords(string Text)
        {
            Dictionary<string, int> UniqueWordCounter = new Dictionary<string, int>(0);
            string[] TextArray = Text.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in TextArray)
            {
                if (UniqueWordCounter.ContainsKey(str) == true)
                {
                    UniqueWordCounter[str]++;
                }
                else
                {
                    UniqueWordCounter.Add(str, 1);
                }
            }
            foreach (KeyValuePair<string, int> keyValue in UniqueWordCounter)
            {
                Console.WriteLine(keyValue.Key + " : " + keyValue.Value);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string Text = Console.ReadLine();
            ToCountWords(Text);

        }
    }
}
