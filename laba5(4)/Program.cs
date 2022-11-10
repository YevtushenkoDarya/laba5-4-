using System;
using System.Globalization;

namespace LaBa5
{
    public class Program
    {
        public static int Factorial(int result)
        {
            
            int count = 1;
            for (int i = 1; i <=result; i++)
            {
                count = count * i;
            }
            return count;
        }
        public static double RoundDouble( double number)
        {
            return Math.Round(number, 2, MidpointRounding.AwayFromZero);  
        }
        static void Main()
        {
            string[] InputArray; // создаём массив из строк
            string inputstr = Console.ReadLine();// вводим данные пользователя
            InputArray = inputstr.Split(" ");//делим строку на подстроки
            string[] OutputArray = new string[InputArray.Length];// создаём массив для хранения измененного варианта массива
            bool TryParseResult;

            for (int i = 0; i < InputArray.Length; i++)
            {               
                if (int.TryParse(InputArray[i], out int result) && result >= 0)//проверка числа на int  и >0
                {
                    OutputArray[i] = Factorial(result).ToString();
                }
                else if (result < 0)
                {
                    OutputArray[i] = result.ToString();
                }
                else if (double.TryParse(InputArray[i], out double number))
                {
                    OutputArray[i] = RoundDouble(number).ToString();
                }
                else OutputArray[i] = InputArray[i];
            }
            Console.WriteLine(string.Join(" ", OutputArray));
        }
    }
}