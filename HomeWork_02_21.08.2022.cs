
void NumberInWeek()
{
    int i=1;
    while ( i == 1 )
    {
        //1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным__________

        Console.Clear();
        int NumberOfDay = 0;

        int a = 1;
        while ( a==1 )
        {   
            Console.Write ("Введите номер дня недели: ");                   //ввод данных
            NumberOfDay = int.Parse (Console.ReadLine()?? "0");             

            if (NumberOfDay > 7 | NumberOfDay < 1)                          //проверка ввода данных
                Console.WriteLine("не верный ввод");                         
            else                                                            
                a++;                                                        
        }
        if (  NumberOfDay > 5 ) Console.WriteLine("Это выходной день");     //решение задачи
        else Console.WriteLine("Это будний день");                          

    //___________________________________________________________________________________________
        
        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");                                     
        int q = int.Parse(Console.ReadLine()??"0");
        if (q == 0 ) 
            i++;
    }
}
void TwoNumbersCheck()
{
    int i=1;
    while ( i == 1 )
    {
        //2. По двум заданным числам проверять является ли одно квадратом другого______________________

        Console.Clear();
        Console.WriteLine("По двум заданным числам проверять является ли одно квадратом другого");

        Console.Write("Введите первое число : ");                                   //ввод данных
        int FirstNumber = int.Parse (Console.ReadLine()??"0");                      
        Console.Write("Введите второе число : ");                               
        int SecondNumber = int.Parse (Console.ReadLine()??"0");                       

        if ( FirstNumber * FirstNumber == SecondNumber )                            //решение задачи
            Console.WriteLine("второе число является квадратом первого");                            
        if ( SecondNumber * SecondNumber == FirstNumber )                           
            Console.WriteLine("первое число является квадратом второго");
        if (FirstNumber * FirstNumber != SecondNumber & SecondNumber * SecondNumber != FirstNumber)
            Console.WriteLine("данные числа не являются квадратом друг друга");     

         //__________________________________________________________________________________________
            
            Console.WriteLine();
            Console.Write("продолжить '1' , выйти главное меню '0' : ");                                     
            int q = int.Parse(Console.ReadLine()??"0");
            if (q == 0 ) 
                i++;
    }
}
void Coordinates()
{
    int i=1;
    while ( i == 1 )

    //3. Задать номер четверти, показать диапазоны для возможных координат_______________________
    {
        Console.Clear();
        Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат");

        Console.Write("Введите номер четверти : ");                                     //ввод данных
        int quarter = int.Parse(Console.ReadLine()??"0");

        if ( quarter < 1 | quarter > 4 ) Console.WriteLine("не верный ввод");           //решение заачи
        else
            if ( quarter == 1 ) Console.WriteLine ("X > 0 , Y > 0");
            else 
                if ( quarter == 2 ) Console.WriteLine("X < 0 , Y > 0");
                else 
                    if ( quarter == 3 ) Console.WriteLine("X < 0 , Y < 0");
                    else
                        if ( quarter == 4 ) Console.WriteLine("X > 0 , Y < 0");
    
        //________________________________________________________________________________________
        
        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");                                     
        int q = int.Parse(Console.ReadLine()??"0");
        if (q == 0 ) 
            i++;
    }
}
void XYZ()
{
    int i = 1;
    while ( i == 1 )
        //4. Найти расстояние между точками в пространстве 2D/3D__________________________________________
    {
        Console.Clear();
        Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");

        Console.Write("введите '2' для пространства 2D , '3' для 3D : ");                                  //ввод данных
        int p = int.Parse(Console.ReadLine()??"0");
        if ( p == 2 ) 
        {
            Console.WriteLine("Введите 'X1' : ");
            int x1 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'Y1' : ");
            int y1 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'X2' : ");
            int x2 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'Y2' : ");
            int y2 = int.Parse( Console.ReadLine()??"0");

            double d2 = Math.Sqrt(Math.Pow(( x2 - x1 ),2) + Math.Pow(( y2-y1 ),2));
            Console.WriteLine ("расстояние между точками в пространстве 2D : " + d2);
        }
        if ( p == 3 )
        {
            Console.WriteLine("Введите 'X1' : ");
            int x1 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'Y1' : ");
            int y1 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'X2' : ");
            int x2 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'Y2' : ");
            int y2 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'Z1' : ");
            int z1 = int.Parse( Console.ReadLine()??"0");
            Console.WriteLine("Введите 'Z2' : ");
            int z2 = int.Parse(Console.ReadLine()??"0");

            double d3 = Math.Sqrt(Math.Pow(( x2 - x1 ),2) + Math.Pow(( y2-y1 ),2) + Math.Pow((z2-z1),2));
            Console.WriteLine ("расстояние между точками в пространстве 3D : " + d3);
        }     
        //________________________________________________________________________________________
        
        Console.WriteLine();
        Console.Write("продолжить '1' , выйти главное меню '0' : ");                                     
        int q = int.Parse(Console.ReadLine()??"0");
        if (q == 0 ) 
            i++;
    }

}

//MENU 

int j = 1;
while ( j == 1 )
{
    Console.Clear ();

    Console.WriteLine("1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
    Console.WriteLine("2. По двум заданным числам проверять является ли одно квадратом другого");
    Console.WriteLine("3. Задать номер четверти, показать диапазоны для возможных координат");
    Console.WriteLine("4. Найти расстояние между точками в пространстве 2D/3D");
    Console.Write("Введите номер задания и нажмите ENTER , для выхода введите '0' : ");


    int z = int.Parse(Console.ReadLine()??"0");

    if ( z == 1 ) NumberInWeek();
    else
        if ( z == 2 ) TwoNumbersCheck();
        else
            if ( z == 3 ) Coordinates();
            else
                if ( z == 4 ) XYZ();
                else
                    if ( z == 0) j++;
}





    

