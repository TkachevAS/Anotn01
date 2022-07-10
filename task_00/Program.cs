// See https://aka.ms/new-console-template for more information

// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write ("Write full number: ");
int num=Convert.ToInt32(Console.ReadLine());
int sqare = num*num;

Console.Write ($"Sqare number {num}={sqare}");
