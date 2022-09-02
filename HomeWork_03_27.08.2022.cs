//1. Найти кубы чисел от 1 до N____________________________________________________________________

void exercise_1 ()
{
    Console.Clear();
    Console.WriteLine("Найти кубы чисел от 1 до N");
    Console.Write("введите число 'N' : ");
    int n = int.Parse(Console.ReadLine()??"0");

    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
        i++;
    }
}

//2. Возведите число А в натуральную степень B используя цикл________________________________________

void exercise_2()
{
    Console.Clear();
    Console.WriteLine("Возведите число А в натуральную степень B используя цикл");

    Console.Write("введите число 'A' : ");
    int a = int.Parse(Console.ReadLine()??"0");
    Console.Write("введите число 'B' : ");
    int b = int.Parse(Console.ReadLine()??"0");
    
    if ( b == 0 )
    {
        Console.WriteLine("0");
        return;
    }
    int n=a;
    for ( int i=2 ; i <= b ; i++ )
    {
        n = n * a;
    }
    Console.WriteLine ( "полученное число : " + n );

}

//3. Подсчитать сумму цифр в числе_____________________________________________________________

void exercise_3()
{
    Console.Clear();
    Console.WriteLine("Подсчитать сумму цифр в числе");

    Console.Write("введите число 'N' : ");
    int n = int.Parse(Console.ReadLine()??"0");
    int a = 0;
    int m = 0;
 
    while ( n > 0 )
    {
        a = n % 10;
        n = n / 10;
        m = m + a;
    }
    Console.WriteLine("сумма цифр в числе : " + m);
}

//4. Написать программу вычисления произведения чисел от 1 до N_______________________________________

void exercise_4()
{
    Console.Clear();
    Console.WriteLine("вычисление произведения чисел от 1 до N");

    Console.Write("введите число 'N' : ");
    int n = int.Parse(Console.ReadLine()??"0");

    int a = 1;
    
    for ( int i = 1 ; i <= n ; i++ )
    {
        a = a * i ;
    }
    Console.WriteLine("произведение чисел от 1 до N равно : " + a);
}

//5. Показать кубы чисел, заканчивающихся на четную цифру__________________________________________

void exercise_5()
{
    Console.Clear();
    Console.WriteLine("Показать кубы чисел , заканчивающихся на четную цифру ");

    Console.WriteLine("Введите диапазон случайных чисел от 'A' до 'B' ");           //ввод данных
    Console.WriteLine("Введите число 'A' : ");
    int a = int.Parse(Console.ReadLine()??"0");
    Console.WriteLine("Введите число 'B' : ");
    int b = int.Parse(Console.ReadLine()??"0");
    Console.WriteLine("Введите необходимое количество случайных чисел в заданном диапазоне : ");
    int c = int.Parse(Console.ReadLine()??"0");

    int [] randomNumbers = new int [ c ];                                    //заполнение массива

    for ( int i = 0 ; i < c ; i++)
    {
        randomNumbers [i] = new Random().Next(a,b);
    }

    for ( int i = 0 ; i < c ; i++)                                             //решение задачи
    {
        if ( Math.Pow(randomNumbers [i],3) % 2 == 0 )
        {
            Console.Write($"индекс масива : {i} число под индексом : {randomNumbers[i]} ");
            Console.WriteLine($"куб числа : {Math.Pow(randomNumbers[i],3)} ");
        }
        else
            Console.WriteLine($"индекс масива : {i} число под индексом : {randomNumbers[i]} ");
    }
    
}

//6. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран________________

void exercise_6()
{
    Console.Clear();
    Console.WriteLine("Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
    
    int [] randomNumbers = new int [ 8 ];                                  

    for ( int i = 0 ; i < 8 ; i++)
    {
        randomNumbers [i] = new Random().Next(0,2);
        Console.WriteLine($"индекс масива : {i} число под данным индексом : {randomNumbers[i]} ");
    }
      
}

//7. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//   Найти сумму положительных/отрицательных элементов массива_________________________________________

void exercise_7()
{
    Console.Clear();
    Console.WriteLine("Задать массив из 12 элементов, заполненных числами из [0,9]. ");
    Console.WriteLine("Найти сумму положительных/отрицательных элементов массива");
    
    int [] randomNumbers = new int [ 12 ];                                    //заполнение массива

    for ( int i = 0 ; i < 12 ; i++ )
    {
        randomNumbers [i] = new Random().Next(0,9);
        Console.WriteLine($"индекс масива : {i} число под данным индексом : {randomNumbers[i]} ");
    }

    int SumPositiveNum = 0;
    int SumNegativeNum = 0;

    for ( int i = 0 ; i < 12 ; i++ )
    {
        if ( randomNumbers [i] > 0 ) 
        {
            SumPositiveNum = SumPositiveNum + randomNumbers [i];}
        else
            {SumNegativeNum = SumNegativeNum + randomNumbers [i];}
    }
    Console.WriteLine("сумма положительных чисел : " + SumPositiveNum);
    Console.WriteLine("сумма отрицательных чисел : " + SumNegativeNum);

}

//MENU ________________________________________________________________________________________

int j = 1;
while ( j == 1 )
{
    Console.Clear ();

    Console.WriteLine("1. Найти кубы чисел от 1 до N");
    Console.WriteLine("2. Возведите число А в натуральную степень B используя цикл");
    Console.WriteLine("3. Подсчитать сумму цифр в числе");
    Console.WriteLine("4. Написать программу вычисления произведения чисел от 1 до N");
    Console.WriteLine("5. Показать кубы чисел, заканчивающихся на четную цифру");
    Console.WriteLine("6. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
    Console.WriteLine("7. Задать массив из 12 элементов, заполненных числами из [0,9]. ");
    Console.WriteLine("   Найти сумму положительных/отрицательных элементов массива");
    Console.Write("Введите номер задания и нажмите ENTER , для выхода введите '0' : ");


    int z = int.Parse(Console.ReadLine()??"0");
    if ( z == 0) 
        break;

    int i = 1;
    while ( i == 1 )
    {

    if ( z == 1 ) 
        exercise_1(); 
    else
        if ( z == 2 ) 
            exercise_2();
        else
            if ( z == 3 ) 
                exercise_3();
            else
                if ( z == 4 ) 
                    exercise_4();
                else
                    if ( z == 5 )
                        exercise_5();
                    else
                        if ( z == 6 )
                            exercise_6();
                        else
                            if ( z == 7 )
                                exercise_7();
                            

        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");                                     
        int q = int.Parse(Console.ReadLine()??"0");
        if ( q == 0 ) 
            i++;
    }
}

