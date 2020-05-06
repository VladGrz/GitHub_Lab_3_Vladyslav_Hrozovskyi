using System;

namespace Lab_3
{
    class Program
    {
        static void DelSlovaAndNumers(string[] slova)
        {
            bool propusk = true;
            Console.WriteLine("Ваш тест, у якому видаленi слова, що мiстять хоча б одну латинську лiтеру, та числа:");
            for (int i = 0; i < slova.Length; i++)
            {
                foreach (char bukva in slova[i])
                {
                    if (((int)bukva >= 97 && (int)bukva <= 122) || ((int)bukva >= 65 && (int)bukva <= 90)) propusk = false;
                    if (char.IsDigit(bukva)) propusk = false;
                }
                if (propusk == true) Console.Write(slova[i] + " ");
                propusk = true;
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть текст: ");
            string str = Console.ReadLine();
            string[] words = str.Split(',', ' ', ';', '"', '(',')','.');
            DelSlovaAndNumers(words);
        }
    }
}
