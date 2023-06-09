using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scanner
{
    public static class LexicalScanner
    {
        public struct LexicalItem
        {
            public Codes lexicalCode;
            public string item;
            public int startPosition;
            public int endPosition;

            public LexicalItem(Codes code, string item, int startPosition, int endPosition)
            {
                this.lexicalCode = code;
                this.item = item;
                this.startPosition = startPosition;
                this.endPosition = endPosition;
            }

            public override string ToString()
            {
                return $"{startPosition}:{endPosition}  [{item}]: {lexicalCode}: {Convert.ToInt16(lexicalCode)}";
            }
        }

        public enum Codes
        {
            ErrorCode = -1,
            IdentifierCode = 1,
            PlusCode,
            MinusCode,
            PercentCode,
            DivideCode,
            DoubleDivideCode,
            MultiplyCode,
            DoubleMultiply, 
            SpaceConstCode,
            IntegerConstCode,
            DoubleConstCode,
            EqualCode,
        }

        private static Codes IsArithmOperator(string text)
        {
            if (text == "")
            {
                return Codes.ErrorCode;
            }

            switch (text)
            {
                case "+":
                    return Codes.PlusCode;
                case "-":
                    return Codes.MinusCode;
                case "*":
                    return Codes.MultiplyCode;
                case "**":
                    return Codes.DoubleMultiply;
                case "/":
                    return Codes.DivideCode;
                case "//":
                    return Codes.DoubleDivideCode;
                case "%":
                    return Codes.PercentCode;
                default:
                    return Codes.ErrorCode;
            }
        }

        private static Codes IsNumber(string text)
        {
            if (text == "")
            {
                return Codes.ErrorCode;
            }

            int integerConst = 0;

            if (int.TryParse(text, out integerConst))
            {
                return Codes.IntegerConstCode;
            }

            // Проверяет первое число на то что это цифра. \ Checks if the first number is a digit
            if (Char.IsDigit(text[0]))
            {
                int i = 0;
                int countDot = 0;

                while (i < text.Length)
                {
                    if (text[i] == '.')
                    {
                        countDot++;         // Точка должна быть только одна \ There must be only one point
                    }
                    i++;
                }

                if (countDot == 1)
                {
                    return Codes.DoubleConstCode;
                }
            }
            // Если TryParse вернул false или в строке больше одной точки.
            // \ If TryParse returned false or there is more than one dot in the string.
            return Codes.ErrorCode;
        }

        private static Codes IsIdentifier(string text)
        {
            if (text == "")
            {
                return Codes.ErrorCode;
            }

            if (!Char.IsLetter(text[0]))
            {
                return Codes.ErrorCode;
            }
            else
            {
                foreach (char c in text)
                {
                    if (c != '_' && !Char.IsDigit(c) && !Char.IsLetter(c))
                    {
                        return Codes.ErrorCode;
                    }
                }
            }
            return Codes.IdentifierCode;
        }

        private static char GetNext(string text, int currentPosition)
        {
            return text[currentPosition + 1];
        }

        public static List<LexicalItem> GetTokens(string inputString)
        {
            int i = 0;
            string answer = "";
            var parts = new List<LexicalItem>();
            string subString = "";

            while (i < inputString.Length)
            {
                char c = inputString[i];

                // Это оператором =. \ It is an operator.
                if (c == '=')
                {
                    int start = i + 1;
                    i++;
                    parts.Add(new LexicalItem(Codes.EqualCode, c.ToString(), start, i + 1));
                    continue;
                }

                // Может быть идентификатором. \ Can be an identifier.
                if (Char.IsLetter(c))
                {
                    subString = "";
                    int start = i + 1;
                    while (i < inputString.Length - 1 && Char.IsLetter(inputString[i]))
                    {
                        subString += inputString[i];
                        i++;
                    }

                    while ((i < inputString.Length) && (Char.IsLetter(inputString[i]) || Char.IsDigit(inputString[i])))
                    {
                        subString += inputString[i];
                        i++;
                    }

                    parts.Add(new LexicalItem(IsIdentifier(subString), subString, start, i));
                    continue;
                }

                // Может быть числом. \ Can be a number.
                if (Char.IsDigit(c))
                {
                    subString = "";
                    int start = i + 1;

                    while ((i < inputString.Length) && (Char.IsDigit(inputString[i]) || inputString[i] == '.'))
                    {
                        subString += inputString[i];
                        i++;
                    }

                    if (subString.EndsWith("."))
                    {
                        parts.Add(new LexicalItem(Codes.ErrorCode, subString, start, i));
                    }
                    else
                    {
                        parts.Add(new LexicalItem(IsNumber(subString), subString, start, i));
                    }

                    subString = "";
                }

                if (c == '*')
                {
                    subString = c.ToString();
                    int start = i + 1;
                    if (i < inputString.Length - 1 || GetNext(inputString, i) == '*')
                    {
                        i++;
                        subString += inputString[i];
                    }
                    i++;
                    parts.Add(new LexicalItem(IsArithmOperator(subString), subString, start, i));
                    continue;
                }

                if (c == '/')
                {
                    subString = c.ToString();
                    int start = i + 1;
                    if (i < inputString.Length - 1 || GetNext(inputString, i) == '/')
                    {
                        i++;
                        subString += inputString[i];
                    }
                    i++;
                    parts.Add(new LexicalItem(IsArithmOperator(subString), subString, start, i));
                    continue;
                }

                // Это арифметический оператор. \ It is an arithmetic operator.
                if (IsArithmOperator(c.ToString()) != Codes.ErrorCode)
                {
                    i++;
                    parts.Add(new LexicalItem(IsArithmOperator(c.ToString()), c.ToString(), i, i));
                    continue;
                }
                if (Char.IsWhiteSpace(c))
                {
                    parts.Add(new LexicalItem(Codes.SpaceConstCode, c.ToString(), i + 1, i + 1));
                    i++;
                    continue;
                }
                if (!Char.IsLetter(c) && !Char.IsDigit(c) && c != '.')
                {
                    i++;
                    parts.Add(new LexicalItem(Codes.ErrorCode, c.ToString(), i, i));
                }
            }

            return parts;
        }
    }
}
