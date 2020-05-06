using System;
using System.IO;

namespace Lab_3_zavd_3
{
    class Program
    {
        static int IndexDvokrapka(string text)
        {
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ':')
                {
                    index = i + 1;
                    break;
                }
            }
            return index;
        }
        static void NumOfSentences(string text)
        {
            int index = IndexDvokrapka(text);
            var result = new StreamWriter("output.txt");
            result.Write(text.Substring(index));
            string[] sentences = text.Split('.', '?', '!');
            string[] slova;
            int numOfSentences = 0;
            for (int i = 0; i < sentences.Length-1; i++)
            {
                sentences[i] = sentences[i].Trim(new char[] { ',', '.', ':','"',';','(',')'});
                if (sentences[i].StartsWith(' ')) sentences[i] =  sentences[i].Substring(2);
                if (sentences[i].EndsWith(' ')) sentences[i] = sentences[i].Remove(sentences[i].Length-1);
                slova = sentences[i].Split(' ');
                if ((slova.Length) % 2 != 0)
                {
                    numOfSentences++;
                }
                Array.Clear(slova, 0, slova.Length);
            }
            result.Write(Environment.NewLine);
            result.Write("Кількість речень з непарною кількістю слів: " + numOfSentences);
            result.Close();
        }
        static void Main(string[] args)
        {
            var file = new StreamReader("D:/ООП/Lab_3/Lab_3_zavd_3/Lab_3_zavd_3/Input.txt");
            string text = file.ReadToEnd();
            file.Close();
            NumOfSentences(text);
        }
    }
}
