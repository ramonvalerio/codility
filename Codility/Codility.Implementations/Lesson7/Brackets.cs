using System.Collections.Generic;

namespace Codility.Implementations.Lesson7
{
    public class Brackets
    {
        public int solution(string S)
        {
            var pares = new Dictionary<char, char>();
            pares.Add('}', '{');
            pares.Add(']', '[');
            pares.Add(')', '(');

            var pilha = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (pares.ContainsKey(S[i]))
                {
                    if (pilha.Count == 0)
                        return 0;

                    if (pilha.Pop() != pares[S[i]])
                        return 0;
                }
                else
                {
                    pilha.Push(S[i]);
                }
            }

            return pilha.Count == 0 ? 1 : 0;
        }

        public int solution2(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
                return 1;

            var pares = new Dictionary<char, char>();
            pares.Add('}', '{');
            pares.Add(']', '[');
            pares.Add(')', '(');

            var pilha = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (pares.ContainsKey(S[i]))
                {
                    if (pilha.Count == 0)
                        return 0;

                    if (pilha.Pop() != pares[S[i]])
                    {
                        return 0;
                    }
                }
                else
                {
                    pilha.Push(S[i]);
                }
            }

            return 1;
        }
    }
}
