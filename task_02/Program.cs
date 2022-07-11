// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int d=Convert.ToInt32(Console.ReadLine());
int max=a;
if(a>max) max=a;
if(b>max) max=b;
if(d>max) max=d;
Console.WriteLine("max=");
Console.WriteLine(max);