
//1. Показать двумерный массив размером m×n заполненный вещественными числами___________________________

void exercise_1()
{
    int m = 4;                                                                    //количество строк
    int n = 3;                                                                    //количество столбцов

    Console.Clear();
    Console.WriteLine("1. Показать двумерный массив размером mxn заполненный вещественными числами");
    Console.WriteLine();

    double[,] randomDoubleNumbers = new double[m, n];                            //создание массива


    for (int i = 0; i < randomDoubleNumbers.GetLength(0); i++)                   //заполнение массива
    {
        for (int j = 0; j < randomDoubleNumbers.GetLength(1); j++)
        {
            randomDoubleNumbers[i, j] = new Random().NextDouble();
        }
    }

    Console.WriteLine("массив : ");                                              //печать массива
    for (int i = 0; i < randomDoubleNumbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomDoubleNumbers.GetLength(1); j++)
        {
            Console.Write(randomDoubleNumbers[i, j] + " ");
        }
    }
}
//2. Задать двумерный массив следующим правилом: Aₘₙ = m+n__________________________________________

void exercise_2()
{
    int m = 4;                                                                    //количество строк
    int n = 3;                                                                    //количество столбцов

    Console.Clear();
    Console.WriteLine("2. Задать двумерный массив следующим правилом: A(m,n) = m+n");
    Console.WriteLine();

    int[,] Numbers = new int[m, n];                                        //создание массива

    for (int i = 0; i < Numbers.GetLength(0); i++)                         //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = i + j;
        }
    }

    Console.WriteLine("массив : ");                                          //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }
}
//3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты________________

void exercise_3()
{
    int m = 4;                                                                    //количество строк
    int n = 3;                                                                    //количество столбцов

    Console.Clear();
    Console.WriteLine("3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
    Console.WriteLine();

    double[,] Numbers = new double[m, n];                                        //создание массива

    for (int i = 0; i < Numbers.GetLength(0); i++)                               //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);

            if (i % 2 == 0 && j % 2 == 0)
                Numbers[i, j] = Math.Pow(Numbers[i, j], 2);
        }
    }

    Console.WriteLine("массив : ");                                              //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }
}

//4. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.____________________

void exercise_4()
{
    int m = 4;                                                                    //количество строк
    int n = 3;                                                                    //количество столбцов
    double averageNumber = 0;

    Console.Clear();
    Console.WriteLine("4. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
    Console.WriteLine();



    double[,] Numbers = new double[m, n];                                               //создание массива

    for (int i = 0; i < Numbers.GetLength(0); i++)                               //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);
        }
    }

    Console.WriteLine("массив : ");                                              //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }
    Console.WriteLine();

    for (int j = 0; j < Numbers.GetLength(1); j++)                               //вычисление среднего
    {                                                                            //арифметического столбцов
        for (int i = 0; i < Numbers.GetLength(0); i++)
        {
            averageNumber = averageNumber + Numbers[i, j];
        }
        averageNumber = averageNumber / m;
        Console.WriteLine($"среднее арифметическое столбца {j} = " + averageNumber);
    }
}

//5. Написать программу, которая обменивает элементы первой строки и последней строки._______________

void exercise_5()
{
    int m = 4;                                                                    //количество строк
    int n = 3;                                                                    //количество столбцов
    int a = 0;                                                                    //доп.переменная для замен

    Console.Clear();
    Console.WriteLine("5. Написать программу, которая обменивает элементы первой строки и последней строки.");
    Console.WriteLine();


    int[,] Numbers = new int[m, n];                                               //создание массива

    for (int i = 0; i < Numbers.GetLength(0); i++)                                //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);
        }
    }

    Console.WriteLine("массив : ");                                               //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }
    Console.WriteLine();

    for (int j = 0; j < Numbers.GetLength(1); j++)                               //замена элементов
    {                                                                            //первой и последней
        a = Numbers[0, j];                                                       //строк
        Numbers[0, j] = Numbers[m - 1, j];
        Numbers[m - 1, j] = a;
    }

    Console.WriteLine("массив : ");                                  //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }
    Console.WriteLine();
}

//6. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива._______________________

void exercise_6()
{
    Console.Clear();
    Console.WriteLine("6. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine();

    int m = 5;                                                                    //количество строк
    int n = 10;                                                                   //количество столбцов

    int[,] Numbers = new int[m, n];                                               //создание массива

    for (int i = 0; i < Numbers.GetLength(0); i++)                                //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);
        }
    }

    Console.WriteLine("массив : ");                                                //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }

    for (int i = 0; i < Numbers.GetLength(0); i++)                                   //сортировка
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            int minNum = Numbers[i, 0];
            for (int l = 1; l < Numbers.GetLength(1); l++)
            {
                if (minNum < Numbers[i, l])
                {
                    Numbers[i, l - 1] = Numbers[i, l];
                    Numbers[i, l] = minNum;
                }
                else
                    minNum = Numbers[i, l];
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("массив : ");                                                 //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }

    Console.WriteLine();
    Console.WriteLine();
}

//7. Написать программу, которая в 
//   двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
//   (в случае, если матрица не квадратная).________________________________________________________________________________

void exercise_7()
{
    Console.Clear();
    Console.WriteLine("7. Написать программу, которая в двумерном массиве заменяет строки на столбцы.");
    Console.WriteLine();

    int m = 5;                                                                    //количество строк
    int n = 5;                                                                    //количество столбцов

    int[,] Numbers = new int[m, n];                                               //создание массива

    if (m != n)                                                                    //проверка 
    {
        Console.WriteLine("Матрица не квадратная, произвести замену корректно не возможно");
        return;
    }

    for (int i = 0; i < Numbers.GetLength(0); i++)                                //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);
        }
    }

    Console.WriteLine("массив : ");                                                //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }

    int num = 0;                                                                    //замена
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        for (int j = i; j < Numbers.GetLength(1); j++)
        {
            num = Numbers[i, j];
            Numbers[i, j] = Numbers[j, i];
            Numbers[j, i] = num;
        }
    }

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("массив : ");                                                //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }

    Console.WriteLine();
    Console.WriteLine();
}

//8. В прямоугольной матрице найти строку с наименьшей суммой элементов.__________________________________________

void exercise_8()
{
    Console.Clear();
    Console.WriteLine("8. В прямоугольной матрице найти строку с наименьшей суммой элементов.");
    Console.WriteLine();

    int m = 5;                                                                    //количество строк
    int n = 3;                                                                    //количество столбцов
    int MinSumLine = 0;
    int Line = 0;

    int[,] Numbers = new int[m, n];                                               //создание массива
    int[] SumLines = new int[m];                                                    //вспомогательный массив

    for (int i = 0; i < Numbers.GetLength(0); i++)                                //заполнение массива
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);
        }
    }

    Console.WriteLine("массив : ");                                                //печать массива
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write(Numbers[i, j] + "     ");
        }
    }


    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            SumLines[i] = SumLines[i] + Numbers[i, j];
        }
    }

    MinSumLine = SumLines[0];
    for (int i = 1; i < Numbers.GetLength(0); i++)
    {
        if (MinSumLine > SumLines[i])
        {
            MinSumLine = SumLines[i];
            Line = i;
        }

    }

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"минимальная сумма элементов '{MinSumLine}' в строке под индексом '{Line}' ");

    Console.WriteLine();


}

//MENU ________________________________________________________________________________________

int j = 1;
while (j == 1)
{
    Console.Clear();

    Console.WriteLine("1. Показать двумерный массив размером mxn заполненный вещественными числами");
    Console.WriteLine("2. Задать двумерный массив следующим правилом: A(m,n) = m+n.");
    Console.WriteLine("3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.");
    Console.WriteLine("4. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
    Console.WriteLine("5. Написать программу, которая обменивает элементы первой строки и последней строки.");
    Console.WriteLine("6. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine("7. Написать программу, которая в двумерном массиве заменяет строки на столбцы.");
    Console.WriteLine("8. В прямоугольной матрице найти строку с наименьшей суммой элементов.");
    Console.Write("Введите номер задания и нажмите ENTER , для выхода введите '0' : ");


    int z = int.Parse(Console.ReadLine() ?? "0");
    if (z == 0)
        break;

    int i = 1;
    while (i == 1)
    {
        if (z == 1)
            exercise_1();
        else
        if (z == 2)
            exercise_2();
        else
        if (z == 3)
            exercise_3();
        else
        if (z == 4)
            exercise_4();
        else
        if (z == 5)
            exercise_5();
        else
        if (z == 6)
            exercise_6();
        else
        if (z == 7)
            exercise_7();
        else
        if (z == 8)
            exercise_8();

        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");
        int q = int.Parse(Console.ReadLine() ?? "0");
        if (q == 0)
            i++;
    }
}


//Numbers[i, j] = new Random().Next(1,10);
//exercise_1();
//exercise_2();
//exercise_3();
//exercise_4();
//exercise_5();
//exercise_6();
//exercise_7();
//exercise_8();
