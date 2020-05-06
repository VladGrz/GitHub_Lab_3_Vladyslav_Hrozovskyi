using System;
using System.IO;

namespace Lab_3_zavd_2
{
    class Program
    {
        static void WriteInFile(string a) {
            string[] numbers = a.Split(" ");

            var zapis = new StreamWriter("D:/ООП/Lab_3/Lab_3_zavd_2/Lab_3_zavd_2/Numbers.txt", true);
            zapis.Write(Environment.NewLine);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) % 2 == 0 && (i + 1) % 2 != 0)
                {
                    zapis.Write(numbers[i] + " ");
                }
            }
            zapis.Close();
            Console.WriteLine("Вміст файлу після виконання програми:\n" + File.ReadAllText("D:/ООП/Lab_3/Lab_3_zavd_2/Lab_3_zavd_2/Numbers.txt"));
            
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:/ООП/Lab_3/Lab_3_zavd_2/Lab_3_zavd_2/Numbers.txt");
            Console.WriteLine("Вміст файлу:\n" + text);
            WriteInFile(text);
        }
    }
}