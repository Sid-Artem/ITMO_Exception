using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.WriteLine("Введите целое число 1.");
                int X = int.Parse(Console.ReadLine());
                Console.WriteLine("X=" + X);
                Console.WriteLine("Введите целое число 2.");
                int Y = int.Parse(Console.ReadLine());
                Console.WriteLine("Y=" + Y);
                Console.WriteLine("Введите код операции");
                Console.WriteLine("1-сложение, 2-вычитание, 3-произведение, 4-частное");
                int Z = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш выбор:" + Z);
                int sum = 0;
                if (Z == 1) sum = X + Y;
                else if (Z == 2) sum = X - Y;
                else if (Z == 3) sum = X * Y;
                else if (Z == 4) sum = X / Y;
                else Console.WriteLine("Нет операции с выбранным номером");
                Console.WriteLine("Результат =" + sum);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
                Console.ReadKey();
            }





        }

    }
}
