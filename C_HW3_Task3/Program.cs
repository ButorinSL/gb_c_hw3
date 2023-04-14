// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message) // int - тип возвращаемого значения, ReadInt - название функции, message - параметр
    {
    Console.Write($"{message} > "); // Вызов функции печати в консоль
    return Convert.ToInt32(Console.ReadLine());; // Возвращаемое значение
    }

double x = ReadInt("Введите число"); // Вызов функции ввода числа

double i = 1;
 while (i <= x)
 {
    double i3 = Math.Pow(i, 3);
    System.Console.Write($"{i3}, ");
    i = i + 1;
 }

