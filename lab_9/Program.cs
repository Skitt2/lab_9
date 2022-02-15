using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.    Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.");
                Console.Write("Введите первое целое число ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе целое число ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("выберите тип операции 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное");
                int actNumber = Convert.ToInt32(Console.ReadLine());
                switch (actNumber)
                {
                    case 1:
                        {
                            Console.WriteLine(" = {0}", firstNumber + secondNumber);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" = {0}", firstNumber - secondNumber);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" = {0}", firstNumber * secondNumber);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(" = {0:f2}", firstNumber / secondNumber);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("введен неверный тип операции");
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
