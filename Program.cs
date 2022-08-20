//поиск наибольшего числа из двух введеных
Console.WriteLine("Введите число 1:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = int.Parse(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else 
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}