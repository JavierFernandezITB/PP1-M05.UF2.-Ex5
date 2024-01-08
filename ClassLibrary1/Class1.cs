using System;

namespace UtilsLib
{
    public class Utils
    {
        public bool IsOddNumber(int value)
        { 
            return (value % 2 != 0);
        }

        public int GetRandomNumber(int minRange, int maxRange)
        { 
            return new Random().Next(minRange, maxRange+1);
        }

        public int CountVowels(string text)
        {
            int count = 0;
            string vowels = "aeiou";
            foreach (char c in text)
            {
                if (vowels.Contains(Convert.ToString(c)))
                    count++;
            }
            return count;
        }

        public int Pow(int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; ++i)
            {
                result *= number;
            }
            return result;
        }

        public void PressAnyKey()
        {
            const string Message = "Presione cualquier tecla para continuar.";
            Console.WriteLine(Message);
            Console.ReadKey();
        }
    }
}
