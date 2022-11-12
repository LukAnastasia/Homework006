// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine();
// int M = 5;           
// int count = 0;

// while (M > 0)
// {
//     Console.Write("Введите число: ");
//     string num = Console.ReadLine();
//     int number = Convert.ToInt32(num);
//     if (number > 0) count++;
//     M--;
// }
// Console.WriteLine($"Количество чисел больше 0: {count}");
// Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double pointX;
double pointY;
Console.WriteLine();
Console.Write("Введите через пробел значения b1, k1, b2 и k2: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int b1 = arr [0];
int k1 = arr [1];
int b2 = arr [2];
int k2 = arr [3];

if (k1 == k2)
{
    Console.WriteLine("Прямые с такими координатами паралельны");
}
else
{
    pointX = (double) (b2-b1)/(k1-k2);
    pointY = (double) k1*(b2-b1)/(k1-k2)+b1;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х= {pointX:0.00}");
    Console.WriteLine($"Y= {pointY:0.00}");
}
Console.WriteLine(); 