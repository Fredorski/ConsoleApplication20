using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionThings
{
    public static class MyStringExtension
    {
        public static string Dotify(this string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            string result = text.Trim();
            if (result[result.Length - 1] != '.')
                return result + '.';
            else
                return result;
        }
        public static string PlussPussa(this string tal)
        {
            return tal + tal;
        }
    }
}
