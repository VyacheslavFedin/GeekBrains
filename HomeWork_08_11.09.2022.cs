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

// 3.Найти сумму цифр числа_______________________________________________________________

void Exercise_03()
{
    Console.Clear();
    Console.WriteLine("Найти сумму цифр числа.");

    Console.Write("введите число : ");
    int M = int.Parse(Console.ReadLine() ?? "0");

    int N = M;
    int sum = 0;

    while (N > 0)
    {
        sum = sum + (N % 10);
        N = N / 10;
    }

    Console.WriteLine("сумма цифр числа : " + sum);
}

//4. Написать программу вычисления функции Аккермана__________________________________________

void Exercise_04()
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

//5. Написать программу возведения числа А в целую степень B_________________________________________


void Exercise_05()
{
    Console.Clear();
    Console.WriteLine("Написать программу возведения числа А в целую степень B.");

    Console.Write("Введите число A : ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень B : ");
    int B = Convert.ToInt32(Console.ReadLine());

    int degree = 1;
    for (int i = 1; i <= B; i++)
    {
        degree = degree * A;
    }
    Console.WriteLine("результат : " + degree);
}

//6. Написать программу показывающие первые N чисел, 
//   для которых каждое следующее равно сумме двух предыдущих. 
//   Первые два элемента последовательности задаются пользователем________________________________

void Exercise_06()
{
    Console.Clear();
    Console.WriteLine("6. Написать программу показывающие первые N чисел, ");
    Console.WriteLine("   для которых каждое следующее равно сумме двух предыдущих. ");
    Console.WriteLine("   Первые два элемента последовательности задаются пользователем");

    Console.Write("Введите число N : ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите первое число : ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число : ");
    int B = Convert.ToInt32(Console.ReadLine());

    int[] numbers = new int[N];
    numbers[0] = A;
    numbers[1] = B;

    for (int i = 2; i <= N - 1; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }

    Console.WriteLine("ряд чисел : ");
    for (int i = 0; i <= N - 1; i++)
    {
        Console.Write("  " + numbers[i]);
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
    Console.WriteLine("3. Найти сумму цифр числа. ");
    Console.WriteLine("4. Написать программу вычисления функции Аккермана.");
    Console.WriteLine("5. Написать программу возведения числа А в целую степень B");
    Console.WriteLine("6. Написать программу показывающие первые N чисел,");
    Console.WriteLine("   для которых каждое следующее равно сумме двух предыдущих. ");
    Console.WriteLine("   Первые два элемента последовательности задаются пользователем");
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
        else
        if (z == 4)
            Exercise_04();
        else
        if (z == 5)
            Exercise_05();
        else
        if (z == 6)
            Exercise_06();

        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");
        int q = int.Parse(Console.ReadLine() ?? "0");
        if (q == 0)
            i++;
    }
}



//Exercise_01();
//Exercise_02();
//Exercise_03();
//Exercise_04();
//Exercise_05();
//Exercise_06();

