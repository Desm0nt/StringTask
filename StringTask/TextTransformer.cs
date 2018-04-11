using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    class TextTransformer
    {

        public static List<string> TextToUpperCase(List<string> txt)
        {
            for (int i = 0; i< txt.Count; i++)
            {
                if (string.IsNullOrEmpty(txt[i]))
                {
                    txt[i] = "_";
                }
                else
                {
                    txt[i] = new string(ToUpperCase(txt[i]).ToArray());
                }
            }
            return txt;
        }

        static IEnumerable<char> ToUpperCase(string s)
        {
            foreach (char c in s)
            {
                yield return Char.ToUpper(c);
            }
        }
    }
}
