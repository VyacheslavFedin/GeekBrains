//Задание

/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""

Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

//Решение

//1. Показать натуральные числа от M до N, N и M заданы.___________________________________________

void Exercise_01()
{
    Console.Clear();
    Console.WriteLine("Показать натуральные числа от M до N, N и M заданы.");

    Console.Write("введите 'M' : ");
    int M = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("введите 'N' : ");
    int N = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine($"натуральные числа от M = {M} до N = {N} : ");

    if (M < N)
    {
        for (int i = M; i <= N; i++)
        {
            Console.Write("  " + i);
        }
    }

    if (N < M)
    {
        for (int i = M; i >= N; i--)
        {
            Console.Write("  " + i);
        }
    }
    Console.WriteLine();
}

//2.Найти сумму элементов от M до N, N и M заданы______________________________________________

void Exercise_02()
{
    Console.Clear();
    Console.WriteLine("Найти сумму элементов от M до N, N и M заданы.");

    Console.Write("введите 'M' : ");
    int M = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("введите 'N' : ");
    int N = int.Parse(Console.ReadLine() ?? "0");

    int sum = 0;
    Console.WriteLine($"числа от M = {M} до N = {N} : ");

    if (M < N)
    {
        for (int i = M; i <= N; i++)
        {
            sum = sum + i;
            Console.Write("  " + i);
        }
    }

    if (N < M)
    {
        for (int i = M; i >= N; i--)
        {
            sum = sum + i;
            Console.Write("  " + i);
        }
    }
    Console.WriteLine();
    Console.WriteLine($"сумма элементов : {sum}");
}



//3. Написать программу вычисления функции Аккермана__________________________________________

void Exercise_03()
{

    Console.Clear();
    Console.WriteLine("Написать программу вычисления функции Аккермана.");

    Console.Write("Введите число n : ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число m : ");
    int m = Convert.ToInt32(Console.ReadLine());
    A(n, m);

    int A(int n, int m)
    {
        if (n == 0)
        {
            Console.Write(" " + (m + 1));
            return m + 1;
        }
        if (n != 0 && m == 0) return A(n - 1, 1);
        if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
        return A(n, m);
    }
    Console.WriteLine();


}


//MENU ________________________________________________________________________________________

int j = 1;
while (j == 1)
{
    Console.Clear();

    Console.WriteLine("1. Показать натуральные числа от M до N, N и M заданы.");
    Console.WriteLine("2. Найти сумму элементов от M до N, N и M заданы.");
    Console.WriteLine("3. Написать программу вычисления функции Аккермана.");

    Console.Write("Введите номер задания и нажмите ENTER , для выхода введите '0' : ");


    int z = int.Parse(Console.ReadLine() ?? "0");
    if (z == 0)
        break;

    int i = 1;
    while (i == 1)
    {
        if (z == 1)
            Exercise_01();
        else
        if (z == 2)
            Exercise_02();
        else
        if (z == 3)
            Exercise_03();


        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");
        int q = int.Parse(Console.ReadLine() ?? "0");
        if (q == 0)
            i++;
    }
}



