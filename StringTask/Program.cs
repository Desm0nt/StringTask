using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string>();
            text.Add("Quick brown fox jump over tha lazy dog. 123");
            text.Add(null);
            text.Add("The End.");
            text = TextTransformer.TextToUpperCase(text);
            foreach (var a in text)
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
