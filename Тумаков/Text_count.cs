using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Text_count//упражнение 8.2 (слова в обратном порядке)
    {
        public char[] Text1(string text)
        {
            char[] letters = new char[text.Length];
            int j = 0;
            for (int i = text.Length; i >= 1; i--)
            {
                letters[j] = text[i - 1];
                j++;
            }
            return letters;
        }
    }
}
