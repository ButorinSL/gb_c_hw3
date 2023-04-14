// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int ReadInt(string message) // int - тип возвращаемого значения, ReadInt - название функции, message - параметр
    {
    Console.Write($"{message} > "); // Вызов функции печати в консоль
    return Convert.ToInt32(Console.ReadLine());; // Возвращаемое значение
    }

int number = ReadInt("Введите пятизначное число"); // Вызов функции ввода числа

bool ValdaiteNumber_5_Digit (int number)   // проверяем является ли введенное число пятизначным
{
    if (number > 99999 || number <= 9999)
    {
        System.Console.WriteLine("Вы ввели не пятизначное число, пожалуйста повторите ввод");
        return false;
    }
    return true;
}


int digit5 = number % 10;
int digit4 = number / 10 % 10;
// int digit3 = number / 100 % 10; // закоментили строку - так как среднее число (3е) в пятизначном на палиндромность не влияет
int digit2 = number / 1000 % 10;
int digit1 = number / 10000 % 10;

bool Palindrom (int number)    // проверка на палиндром
{
    if (digit1 == digit5 && digit2 == digit4)
    {
        System.Console.WriteLine($"Введеное Вами число {number} - ЯВЛЯЕТСЯ палиндромом");
        return true;
    }
System.Console.WriteLine($"Введеное Вами число {number} - НЕ ЯВЛЯЕТСЯ палиндромом");
return false;
}

if (ValdaiteNumber_5_Digit(number))     //Если по результатам проверки на 5 значность - число 5 значное -
{
    System.Console.WriteLine(Palindrom(number)); // печатаем результат проверки на палиндром
}

