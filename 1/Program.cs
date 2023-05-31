
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write($"Введите A: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите A: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите A: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите B: ");
int z2 = int.Parse(Console.ReadLine()!);


//• AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z1 - z2, 2)); //(x1 - x2) * (x1 - x2)\
Console.Write($"{d:f2}");

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int[] array = new int[a];
for (int i = 1; i <= a; i++)
{
    array[i - 1] = i * i * i;
}
for (int i = 0; i < a; i++)
{
    Console.Write($"{array[i]} ");
}

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write($"Введите число: ");
int n = int.Parse(Console.ReadLine()!);

//проверить 1 с 5, 2 с 4
//1 число = n / 10000
//2 число = n / 10 % 10
//3 число = n % 10
//4 число = n / 10 % 10;
//5 число = n / 1000 % 10
int a = n / 10000;
int b = n / 1000 % 10;
//int c = n / 100 % 10; 
int d = n / 10 % 10;
int e = n % 10;
if(a == e || b == d)
{
Console.Write($"{n} -> да");
}
else
{
    Console.Write($"{n} -> нет");
}
