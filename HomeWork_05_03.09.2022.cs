//1. Найти точку пересечения двух прямых 
//   заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы______________________

void exercise_1()
{
    Console.Clear();
    Console.WriteLine("1. Найти точку пересечения двух прямых.");
    Console.WriteLine("   заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.");
    Console.WriteLine();
    Console.WriteLine("Введите 'k1' : ");
    int k1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите 'b1' : ");
    int b1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите 'k2' : ");
    int k2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите 'b2' : ");
    int b2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых y={k1}*x+{b1} и y={k2}*x+{b2} : ({x};{y})");



}

//2. Написать программу масштабирования фигуры Тут для тех кто далеко улетел, 
//   чтобы задавались вершины фигуры списком (одной строкой) например: 
//   "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался 
//   отдельно - 2 или 4 или 0.5 В результате показать координаты, 
//   которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"_________________________________________

void exercise_2()
{

    Console.Clear();
    Console.WriteLine("введите координаты вершин фигуры (пример : (0,0) (2,0) (2,2) (0,2)) : ");
    string coordinates = Console.ReadLine();

    int[] coord = new int[coordinates.Length];
    int n = 0;
    int m = 0;


    for (int i = 0; i < coordinates.Length; i++)
    {

        if (coordinates[i] == '0') { coord[n] = (coord[n] + 0) * 10; m++; }
        else
        if (coordinates[i] == '1') { coord[n] = (coord[n] + 1) * 10; m++; }
        else
        if (coordinates[i] == '2') { coord[n] = (coord[n] + 2) * 10; m++; }
        else
        if (coordinates[i] == '3') { coord[n] = (coord[n] + 3) * 10; m++; }
        else
        if (coordinates[i] == '4') { coord[n] = (coord[n] + 4) * 10; m++; }
        else
        if (coordinates[i] == '5') { coord[n] = (coord[n] + 5) * 10; m++; }
        else
        if (coordinates[i] == '6') { coord[n] = (coord[n] + 6) * 10; m++; }
        else
        if (coordinates[i] == '7') { coord[n] = (coord[n] + 7) * 10; m++; }
        else
        if (coordinates[i] == '8') { coord[n] = (coord[n] + 8) * 10; m++; }
        else
        if (coordinates[i] == '9') { coord[n] = (coord[n] + 9) * 10; m++; }
        else
            m = 0;



        if (m == 1)
        {
            coord[n] = coord[n] / 10;
            n++;
        }

        if (m > 1)
        {
            coord[n - 1] = (coord[n - 1] * 10) + (coord[n] / 10);
            coord[n] = 0;
        }
    }

    Console.WriteLine($"введеные координаты : ");
    for (int i = 0; i < n; i = i + 2)
    {
        Console.Write($"({coord[i]},{coord[i + 1]}) ");
    }

    Console.WriteLine();
    Console.WriteLine("введите коэффицент : ");
    int k = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("новые координаты :");

    for (int i = 0; i < n; i = i + 2)
    {
        Console.Write($"({coord[i] * k},{coord[i + 1] * k}) ");
    }


}

//3. Написать программу копирования массива._________________________________________________________

void exercise_3()
{
    Console.Clear();
    int[] array_1 = { 5, 8, 9, 6, 2, 4 };  // заданый массив
    int[] array_2 = new int[array_1.Length];// копия заданного массива

    Console.WriteLine("массив array_1 : ");

    for (int i = 0; i < array_1.Length; i++) //печать первого массива
    {
        Console.Write(array_1[i] + " ");
    }

    for (int i = 0; i < array_1.Length; i++) //копирование массива
    {
        array_2[i] = array_1[i];
    }

    Console.WriteLine();
    Console.WriteLine("массив array_1 скопирован в array_2 : ");

    for (int i = 0; i < array_2.Length; i++) //печать копии заданного массива
    {
        Console.Write(array_2[i] + " ");
    }


}



//MENU ________________________________________________________________________________________

int j = 1;
while (j == 1)
{
    Console.Clear();

    Console.WriteLine("1. Найти точку пересечения двух прямых.");
    Console.WriteLine("   заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.");
    Console.WriteLine("2. Написать программу масштабирования фигуры, коэффициент масштабирования k");
    Console.WriteLine("   вершины фигуры задаются списком (одной строкой) например: (0,0) (2,0) (2,2) (0,2).");
    Console.WriteLine("3. Написать программу копирования массива.");

    Console.WriteLine();

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



        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");
        int q = int.Parse(Console.ReadLine() ?? "0");
        if (q == 0)
            i++;
    }
}


//exercise_1();
//exercise_2(); 
//exercise_3();


