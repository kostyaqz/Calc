using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            char again = 'д';
            while (again == 'д')
            {

                Console.WriteLine("Для пользования дробные цифры вводите через запятую, в качестве операторов используйте +,-,*,/");
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите оператор");
                char c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                if (c == '+')
                {
                    double total = a + b;
                    Console.WriteLine("Сумма введенных чисел равна " + total + ".");
                }
                else if (c == '-')
                {
                    double total = a - b;
                    Console.WriteLine("Разность введенных числел равна " + total + ".");
                }
                else if (c == '*')
                {
                    double total = a * b;
                    Console.WriteLine("Произведение введенных чисел равно " + total + ".");
                }
                else if (c == '/')
                {
                    double total = a / b;
                    Console.WriteLine("Отношение введенных чисел равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Неверный оператор");
                }
                Console.WriteLine("Вы хотите продолжить работать с калькулятором? (для продолжения ввердите 'д', для прекращения любой другой символ)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }

    }
}
