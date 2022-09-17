// 1. Найти произведение двух матриц_____________________________________________________________

/*Операция умножения двух матриц выполнима только в том случае, 
если число столбцов в первом сомножителе равно 
числу строк во втором; в этом случае говорят, что матрицы согласованы.*/

void Exercise_01()
{
    Console.Clear();
    Console.WriteLine("1. Найти произведение двух матриц.");

    int m = new Random().Next(2, 5);
    int n = new Random().Next(2, 5);
    int k = new Random().Next(2, 5);

    int[,] matrixA = new int[n, m];                             //первая матрица
    int[,] matrixB = new int[m, k];                             //вторая матрица
    int[,] matrixC = new int[n, k];                             //произведение первой и второй матрицы

    int[,] matrixB2 = new int[m, k];                            //копия второй матрицы для вычислений

    Console.WriteLine("матрица 1 : ");
    for (int i = 0; i < n; i++)                                 //заполнение матрицы А
    {
        for (int j = 0; j < m; j++)
        {
            matrixA[i, j] = new Random().Next(1, 10);
            Console.Write(matrixA[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("матрица 2 : ");
    for (int i = 0; i < m; i++)                                 //заполнение матрицы B и B2
    {
        for (int j = 0; j < k; j++)
        {
            matrixB[i, j] = new Random().Next(1, 10);
            matrixB2[i, j] = matrixB[i, j];
            Console.Write(matrixB[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int h = 0; h < n; h++)                                 //умножение строки А на столбцы В2
    {
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrixB2[j, i] = matrixB2[j, i] * matrixA[h, j];
            }
        }

        for (int i = 0; i < k; i++)                               //сложение столбцов B2 и запись в C
        {
            for (int j = 0; j < m; j++)
            {
                matrixC[h, i] = matrixC[h, i] + matrixB2[j, i];
            }
        }

        for (int i = 0; i < m; i++)                                 //восстановление B2 до B
        {
            for (int j = 0; j < k; j++)
            {
                matrixB2[i, j] = matrixB[i, j];
            }
        }
    }

    Console.WriteLine("произведение матриц : ");
    for (int i = 0; i < n; i++)                                     //печать C
    {
        for (int j = 0; j < k; j++)
        {
            Console.Write(matrixC[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//2. В двумерном массиве целых чисел. Удалить строку и столбец, 
//   на пересечении которых расположен наименьший элемент.________________________________________

void Exercise_02()
{
    Console.Clear();
    Console.WriteLine("2. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.");

    int m = 4;
    int n = 4;

    int[,] matrix = new int[m, n];

    Console.WriteLine("матрица  : ");
    for (int i = 0; i < m; i++)                                 //заполнение матрицы 
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    int minNumber = matrix[0, 0];                               //поиск минимального числа
    int i1 = 0;
    int j1 = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (minNumber > matrix[i, j])
            {
                minNumber = matrix[i, j];
                i1 = i;
                j1 = j;
            }
        }
    }
    Console.WriteLine($"минимальное число : {minNumber} с индексом ({i1},{j1})");

    int[,] matrixWithoutMin = new int[m - 1, n - 1];                                //составление новой матрицы

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i < i1 && j < j1)
                matrixWithoutMin[i, j] = matrix[i, j];
            if (i > i1 && j < j1)
                matrixWithoutMin[i - 1, j] = matrix[i, j];
            if (i < i1 && j > j1)
                matrixWithoutMin[i, j - 1] = matrix[i, j];
            if (i > i1 && j > j1)
                matrixWithoutMin[i - 1, j - 1] = matrix[i, j];
        }
    }

    Console.WriteLine("новая матрица : ");
    for (int i = 0; i < m - 1; i++)                                     //печать новой матрицы
    {
        for (int j = 0; j < n - 1; j++)
        {
            Console.Write(matrixWithoutMin[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

//3. Сформировать трехмерный массив не повторяющимися 
//   двузначными числами показать его построчно на 
//   экран выводя индексы соответствующего элемента_________________________________________________

void Exercise_03()
{
    Console.Clear();
    Console.WriteLine("Сформировать трехмерный массив c не повторяющимися двузначными числами.");

    int m = 3;
    int n = 3;
    int k = 3;
    int[,,] cubeOfNumbers = new int[m, n, k];

    for (int i = 0; i < m; i++)                                                 //заполнение массива
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                cubeOfNumbers[i, j, l] = new Random().Next(10, 100);
            }
        }
    }

    int check = 0;                                              //поиск одинаковых чисел и замена
    while (check == 0)
    {
        check = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int l = 0; l < k; l++)
                {
                    for (int i1 = 0; i1 < m; i1++)
                    {
                        for (int j1 = 0; j1 < n; j1++)
                        {
                            for (int l1 = 0; l1 < k; l1++)
                            {
                                if (i != i1 || j != j1 || l != l1)
                                {
                                    if (cubeOfNumbers[i, j, l] == cubeOfNumbers[i1, j1, l1])
                                    {
                                        cubeOfNumbers[i1, j1, l1] = new Random().Next(10, 100);
                                        check = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    for (int i = 0; i < m; i++)                                                 //печать массива
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                Console.Write(cubeOfNumbers[i, j, l] + $" ({i},{j},{l})  ");
            }
            Console.WriteLine();
        }
    }
}

//4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.__________________

void Exercise_04()
{
    Console.Clear();
    Console.WriteLine("Показать треугольник Паскаля.");
    Console.WriteLine("введите высоту треугольника (5-10) : ");

    int m = int.Parse(Console.ReadLine() ?? "0");

    int[,] matrix = new int[m, m + 2];
    matrix[0, 1] = 1;

    Console.Clear();
    for (int i = 1; i < m; i++)                                                 //заполнение матрицы
    {
        for (int j = 1; j < m + 2; j++)
        {
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
        }
    }

    for (int i = 0; i < m; i++)                                                 //вывод на печать треугольника Паскаля
    {
        Console.WriteLine();
        for (int j = 1; j < m + 2; j++)
        {
            if (matrix[i, j] != 0)
            {
                Console.SetCursorPosition(j * 10 + 50 - (i * 5), i);
                Console.Write(matrix[i, j]);
            }
        }
    }
    Console.WriteLine();

}

//MENU ________________________________________________________________________________________

int j = 1;
while (j == 1)
{
    Console.Clear();

    Console.WriteLine("1. Найти произведение двух матриц.");
    Console.WriteLine("2. В двумерном массиве целых чисел. Удалить строку и столбец,"); 
    Console.WriteLine("   на пересечении которых расположен наименьший элемент.");
    Console.WriteLine("3. Сформировать трехмерный массив не повторяющимися ");
    Console.WriteLine("   двузначными числами показать его построчно на ");
    Console.WriteLine("   экран выводя индексы соответствующего элемента");
    Console.WriteLine("4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.");

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