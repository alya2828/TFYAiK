using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TFYAiK
{
    public struct LexicalItem
    {
        public Codes lexicalCode;
        public char item;
        public int Position;

        public LexicalItem(Codes code, char item, int Position)
        {
            this.lexicalCode = code;
            this.item = item;
            this.Position = Position;
        }

        public override string ToString()
        {
            return $"Позиция:{Position}  [{item}]: {lexicalCode}: {Convert.ToInt16(lexicalCode)}";

        }

        public enum Codes
        {
            a,
            b,
            c,
            d,
            e,
            f
        }
    }

    public static class LexicalScanner
    {


        private static char GetNext(string text, int currentPosition)
        {
            return text[currentPosition + 1];
        }

        public static List<LexicalItem> GetTokens(string inputString)
        {
            int i = 0;
            var parts = new List<LexicalItem>();


            while (i < inputString.Length)
            {
                char c = inputString[i];

                switch (c)
                {
                    case 'a':
                        parts.Add(new LexicalItem(LexicalItem.Codes.a, c, i));
                        break;
                    case 'b':
                        parts.Add(new LexicalItem(LexicalItem.Codes.b, c, i));
                        break;
                    case 'c':
                        parts.Add(new LexicalItem(LexicalItem.Codes.c, c, i));
                        break;
                    case 'd':
                        parts.Add(new LexicalItem(LexicalItem.Codes.d, c, i));
                        break;
                    case 'e':
                        parts.Add(new LexicalItem(LexicalItem.Codes.e, c, i));
                        break;
                    case 'f':
                        parts.Add(new LexicalItem(LexicalItem.Codes.f, c, i));
                        break;
                    default:
                        break;
                }
                i++;
            }

            return parts;
        }
    }
}
