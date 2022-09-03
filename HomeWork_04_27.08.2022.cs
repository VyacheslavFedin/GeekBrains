//1. Определить, присутствует ли в заданном массиве, некоторое число______________________________

void exercise_1()
{
    int arrLng = 1000;
    int rand_A = 0;
    int rand_B = 101;

    Console.Clear();
    Console.WriteLine("сформирован новый массив- "
    + $"- объемом {arrLng} ячеек, содержащий случайные числа от '{rand_A}' до '{rand_B - 1}'");
    Console.WriteLine("Определить, присутствует ли в заданном массиве, некоторое число 'N'");
    Console.WriteLine();

    Console.Write("введите число 'N' : ");                                           //ввод N
    int n = int.Parse(Console.ReadLine() ?? "0");


    int[] randomNumbers = new int[arrLng];                                      //заполнение массива

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(rand_A, rand_B);
    }

    int a = 0;                                                                      // поиск N в массиве
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        if (randomNumbers[i] == n)
        {
            Console.WriteLine($"число 'N'= {n} находится в массиве под индексом : {i}");
            a = a + 1;
        }
    }
    Console.WriteLine($"Всего чисел 'N' = {n} в массиве : " + a);

}

//2. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]__________________

void exercise_2()
{
    int arrLng = 123;
    int rand_A = 0;
    int rand_B = 5000;
    int a = 10;
    int b = 100;

    Console.Clear();
    Console.WriteLine($"В одномерном массиве из {arrLng} чисел диапазона от {rand_A} до {rand_B} "
                     + $"найти количество элементов из отрезка [{a},{b - 1}]");
    Console.WriteLine();


    int[] randomNumbers = new int[arrLng];                                      //заполнение массива

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(rand_A, rand_B);
    }


    int m = 0;                                                                   //решение задачи
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        if (randomNumbers[i] >= a & randomNumbers[i] <= b)
        {
            Console.WriteLine($"число {randomNumbers[i]} находится в массиве под индексом {i} ");
            m++;
        }
    }
    Console.WriteLine($"Всего чисел из отрезка [{a},{b}] в массиве : " + m);

}

//3. Найти произведение пар чисел в одномерном массиве. 
//   Парой считаем первый и последний элемент, второй и предпоследний и т.д.______________________

void exercise_3()
{
    int arrLng = 7;
    int rand_A = 0;
    int rand_B = 5;

    Console.Clear();
    Console.WriteLine($"В одномерном массиве из {arrLng} чисел диапазона от {rand_A} до {rand_B - 1} "
                     + $"найти произведение пар чисел ");
    Console.WriteLine("Парой считаем первый и последний элемент, второй и предпоследний и т.д.");


    int[] randomNumbers = new int[arrLng];

    Console.WriteLine("массив : ");                                             //заполнение массива
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(rand_A, rand_B);
        Console.Write(randomNumbers[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("произведения чисел : ");

    for (int i = 0; i < randomNumbers.Length / 2; i++)                          //решение задачи
    {
        Console.Write(randomNumbers[i] * randomNumbers[arrLng - 1 - i] + " ");

    }
    Console.WriteLine();

}

//4. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void exercise_4()
{
    int arrLng = 7;


    Console.Clear();
    Console.WriteLine($"В одномерном массиве из {arrLng} вещественных чисел  "
                     + $"найдите разницу между максимальным и минимальным элементом ");


    double[] randomNumbers = new double[arrLng];

    Console.WriteLine("массив : ");                                             //заполнение массива
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().NextDouble();
        Console.WriteLine(randomNumbers[i]);
    }

    double min = randomNumbers[0];                                              //поиск min max
    double max = randomNumbers[0];

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        if (min > randomNumbers[i]) min = randomNumbers[i];
        if (max < randomNumbers[i]) max = randomNumbers[i];

    }
    Console.WriteLine("min = " + min);
    Console.WriteLine("max = " + max);
    Console.WriteLine("max - min = " + (max-min));

    Console.WriteLine();
}

//MENU ________________________________________________________________________________________

int j = 1;
while ( j == 1 )
{
    Console.Clear ();

    Console.WriteLine("1. Определить, присутствует ли в заданном массиве, некоторое число");
    Console.WriteLine("2. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
    Console.WriteLine("3. Найти произведение пар чисел в одномерном массиве.");
    Console.WriteLine("   Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
    Console.WriteLine("4. В Указанном массиве вещественных чисел найдите разницу "
                        +"между максимальным и минимальным элементом");
    Console.WriteLine();
    
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
                
                            

        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");                                     
        int q = int.Parse(Console.ReadLine()??"0");
        if ( q == 0 ) 
            i++;
    }
}


//exercise_1();
//exercise_2(); 
//exercise_3();
//exercise_4();

