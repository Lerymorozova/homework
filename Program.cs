﻿// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[5];
// Random rand = new Random();
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-567, 567);
//     Console.Write($"{array[i]} ");
// if (array[i] > 0)
// {
//     result = result + 1;
// }
// }
// Console.WriteLine($"Кол-во элементов > 0: {result}");


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


if ((b1 == b2) && (k1 == k2))
{
    Console.WriteLine($"Прямые пересекаются");
}
else if ((k1 == k2))
{
    Console.WriteLine($"Прямые параллельны");
}
else
{
    double x = -(b1-b2)/(k1-k2);
    double y = k1 * x + b1;


Console.WriteLine($"Пересечение X: {x}, Y: {y}");
}