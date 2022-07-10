// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b=Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine(a);
        Console.WriteLine("Больше");
            Console.WriteLine(b);
}
if(a<b)
{
    Console.WriteLine(b);
        Console.WriteLine("Больше");
            Console.WriteLine(a);
}
else
{
Console.WriteLine(b);
Console.WriteLine("Равно");
Console.WriteLine(a);
}