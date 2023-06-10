using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFYAiK
{
    class FiniteStateMachine
    {
        private int currentTokenIndex;
        private List<LexicalItem> tokens;
        public string result { get; private set; }

        private bool Compare(LexicalItem.Codes code)
        {
            if (tokens[currentTokenIndex].lexicalCode == code)
            {
                return true;
            }
            return false;
        }

        private void Error(string message)
        {
            string errorMsg = $"\n{message} Получено '{tokens[currentTokenIndex]}'";
            result += errorMsg;
            throw new Exception(errorMsg);
        }

        public string InintFSM(List<LexicalItem> tokens)
        {
            this.currentTokenIndex = 0;
            this.tokens = tokens;
            result = null;

            try
            {
                result = "s0 -> ";
                State0();
            }
            catch
            {

                throw;
            }

            return result;
        }
        private void State0()
        {
            if (Compare(LexicalItem.Codes.a))
            {
                currentTokenIndex++;
                result += "s1 -> ";
                State1();
            }
            else
            {
                Error("Ожидалось 'a'");
            }
        }

        private void State1()
        {
            if (Compare(LexicalItem.Codes.b))
            {
                currentTokenIndex++;
                result += "s2 -> ";
                State2();
            }
            else
            {
                Error("Ожидалось 'b'");
            }
        }

        private void State2()
        {
            if (Compare(LexicalItem.Codes.c))
            {
                currentTokenIndex++;
                result += "s3 -> ";
                State3();
            }
            else
            {
                Error("Ожидалось 'c'");
            }
        }
        private void State3()
        {
            if (Compare(LexicalItem.Codes.a) || Compare(LexicalItem.Codes.d))
            {
                switch (tokens[currentTokenIndex].lexicalCode)
                {
                    case LexicalItem.Codes.a:
                        result += "s4 -> ";
                        currentTokenIndex++;
                        State4();
                        break;
                    case LexicalItem.Codes.d:
                        result += "s5 -> ";
                        currentTokenIndex++;
                        State5();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Error("Ожидалось 'a' или 'd'");
            }
        }
        private void State4()
        {
            if (Compare(LexicalItem.Codes.c))
            {
                currentTokenIndex++;
                result += "s3 -> ";
                State3();
            }
            else
            {
                Error("Ожидалось 'c'");
            }
        }
        private void State5()
        {
            if (Compare(LexicalItem.Codes.e) || Compare(LexicalItem.Codes.f))
            {
                switch (tokens[currentTokenIndex].lexicalCode)
                {
                    case LexicalItem.Codes.e:
                        result += "s6 -> ";
                        currentTokenIndex++;
                        State6();
                        break;
                    case LexicalItem.Codes.f:
                        result += "s7";
                        currentTokenIndex++;
                        State7();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Error("Ожидалось 'e' или 'f'");
            }
        }
        private void State6()
        {
            if (Compare(LexicalItem.Codes.e) || Compare(LexicalItem.Codes.f))
            {
                switch (tokens[currentTokenIndex].lexicalCode)
                {
                    case LexicalItem.Codes.e:
                        result += "s6 -> ";
                        currentTokenIndex++;
                        State6();
                        break;
                    case LexicalItem.Codes.f:
                        result += "s7";
                        currentTokenIndex++;
                        State7();
                        break;
                    default:
                        break;

                }
            }
            else
            {
                Error("Ожидалось 'e' или 'f'");
            }
        }
        private void State7()
        {
            if (currentTokenIndex == tokens.Count)
            {
                return;
            }
            else
            {
                Error("Ожидался конец выражения");
            }
        }
    }
}
