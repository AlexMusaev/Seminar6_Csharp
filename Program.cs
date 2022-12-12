// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите ваши числа:");
Console.WriteLine("После ввода числа нажмите Enter:");
Console.WriteLine("Чтобы прекратить ввод, введите (end) и нажмите Enter");

int stop = 0;
int count = 0;
while (stop == 0)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        stop = 1;
    }
    else
    {
        try
        {
            int number = Int32.Parse(input);
            if (number > 0) count += 1;
        }
        catch (FormatException)
        {
            Console.WriteLine($" - это не число");
        }
    }
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение для k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых имеет следующие координаты: x = {x}, y = {y}");