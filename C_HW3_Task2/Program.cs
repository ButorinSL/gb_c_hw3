// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



int ReadInt(string message) // int - тип возвращаемого значения, ReadInt - название функции, message - параметр
    {
    Console.Write($"{message} > "); // Вызов функции печати в консоль
    return Convert.ToInt32(Console.ReadLine());; // Возвращаемое значение
    }

int x1 = ReadInt("Введите координату Х первой точки"); // Вызов функции ввода числа
int y1 = ReadInt("Введите координату Y первой точки"); // Вызов функции ввода числа
int z1 = ReadInt("Введите координату Z первой точки"); // Вызов функции ввода числа

int x2 = ReadInt("Введите координату Х второй точки"); // Вызов функции ввода числа
int y2 = ReadInt("Введите координату Y второй точки"); // Вызов функции ввода числа
int z2 = ReadInt("Введите координату Z второй точки"); // Вызов функции ввода числа

int deltaX = x1 - x2;
int deltaY = y1 - y2;
int deltaZ = z1 - z2;

double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));

string distancePrint = String.Format("{0:f3}", distance);

System.Console.WriteLine($"Расстояние между двумя точками {distancePrint}");
