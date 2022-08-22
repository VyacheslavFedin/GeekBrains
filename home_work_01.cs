int c0 = 1;
while (c0==1)
{
    // menu---------------------------------------------------------------------------------------------------

    Console.Clear();
    Console.WriteLine ("Введите номер задачи и нажмите ENTER.");
    Console.WriteLine ();
    Console.WriteLine ("1.  По двум заданным числам проверять является ли первое квадратом второго.");//строка 28
    Console.WriteLine ("2.  По заданному номеру дня недели вывести его название.");// строка 60
    Console.WriteLine ("3.  Найти максимальное из трех чисел.");// строка 83
    Console.WriteLine ("4.  Выяснить является ли число чётным.");// строка 115
    Console.WriteLine ("5.  Показать четные числа от 1 до N.");// строка 143
    Console.WriteLine ("6.  Показать вторую цифру трёхзначного числа.");// строка 176
    Console.WriteLine ("7.  Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.");// строка 205
    Console.WriteLine ("8.  Удалить вторую цифру трёхзначного числа.");// строка 237
    Console.WriteLine ("9.  Выяснить, кратно ли число заданному, если нет, вывести остаток.");// строка 272
    Console.WriteLine ("10. Найти третью цифру числа или сообщить, что её нет.");//строка 308
    Console.Write ("Введите номер задачи (для выхода введите '0') : ");
    int q = int.Parse ( Console.ReadLine () );

    if ( q==0 ) break;
    Console.Clear();

    if ( q == 1 )  
     
    {
     //1.  По двум заданным числам проверять является ли первое квадратом второго.-------------------------------
        int c1 = 1;
        while ( c1==1 )
        {
            Console.WriteLine("По двум заданным числам проверять является ли первое квадратом второго.");
            Console.WriteLine();

            Console.Write ("Введите число 1: ");
            int a = int.Parse( Console.ReadLine() );

            Console.Write ("Введите число 2: ");
            int b = int.Parse( Console.ReadLine() );

            if ( b * b == a ) Console.WriteLine ("первое число является квадратом второго");
            else Console.WriteLine ("первое число НЕ является квадратом второго");
            
            Console.Write ("для выхода введите '0', для продолжения '1' : ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        }   
    }
     //------------------------------------------------------------------------------------------------------------
    if ( q==2 )
    {
     
        Console.WriteLine("По заданному номеру дня недели вывести его название.");
        Console.WriteLine();

        int c2 = 1;
        while (c2==1)
        {
         // 2.  По заданному номеру дня недели вывести его название.--------------------------------------------

            Console.Write ("Введите номер дня недели (для выхода введите '0'): ");
            int c = int.Parse(Console.ReadLine());

            if ( c==1 ) Console.WriteLine ("Понедельник");
            if ( c==2 ) Console.WriteLine ("Вторник");
            if ( c==3 ) Console.WriteLine ("Среда");
            if ( c==4 ) Console.WriteLine ("Четверг");
            if ( c==5 ) Console.WriteLine ("Пятница");
            if ( c==6 ) Console.WriteLine ("Суббота");
            if ( c==7 ) Console.WriteLine ("Воскресенье");
            if ( c==0 ) break;
        }
    } 
         //---------------------------------------------------------------------------------------------------------------
    if ( q==3 )
    {
     
        int c3 = 1;
        while (c3==1)
        {

     //3.  Найти максимальное из трех чисел.----------------------------------------------------------------------

            Console.WriteLine("Найти максимальное из трех чисел.");
            Console.WriteLine();

            Console.Write ("Введите число 1: ");
            int a1 = int.Parse( Console.ReadLine() );

            Console.Write ("Введите число 2: ");
            int a2 = int.Parse( Console.ReadLine() );

            Console.Write ("Введите число 3: ");
            int a3 = int.Parse( Console.ReadLine() );

            int max = a1;
            if ( max < a2 ) max = a2;
            if ( max < a3 ) max = a3;
            Console.WriteLine ("Наибольшее число : " + max);
     //----------------------------------------------------------------------------------------------------------
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break;
        }
    }

    if ( q==4 )
    {
     
        int c4 = 1;
        while (c4==1)
        {
      //4.  Выяснить является ли число чётным.-----------------------------------------------------------------
            Console.WriteLine("Выяснить является ли число чётным.");
            Console.WriteLine();

            Console.Write ("Введите число : ");
            int a1 = int.Parse( Console.ReadLine() );
 
            if ( a1 % 2 > 0 ) Console.WriteLine ("Число не четное");
             else Console.WriteLine ("Число четное");

      //-------------------------------------------------------------------------------------------------------  
            
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        
        }
    }

    if ( q==5 )
    
    {
     
        int c5 = 1;
        while (c5==1)
        {

         //5.  Показать четные числа от 1 до N.--------------------------------------------------------------------
            
            Console.WriteLine("Показать четные числа от 1 до N.");
            Console.WriteLine();

            Console.Write ("Введите число : ");
            int n = int.Parse( Console.ReadLine() );

            int a=0;
            while (a <= n)
            {
                if ( a % 2 == 0 ) Console.Write(" " + a);
                a++;
            }

            Console.WriteLine();
         //-------------------------------------------------------------------------------------------------------  
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        
        }
    }

    if ( q==6 )
    
    {
     
        int c6 = 1;
        while (c6==1)
        {

         //6.  Показать вторую цифру трёхзначного числа.--------------------------------------------------------------------
            
            Console.WriteLine("Показать вторую цифру трёхзначного числа.");
            Console.WriteLine();

            Console.Write ("Введите число : ");
            int n = int.Parse( Console.ReadLine() );

            n = n / 10;
            n = n % 10;
            Console.Write ( "вторая цифра введеного числа : " + n );
            
            Console.WriteLine();
         //-------------------------------------------------------------------------------------------------------  
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        }
    }

    if ( q==7 )
    
    {
     
        int c7 = 1;
        while (c7==1)
        {

         //7.  Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.--------------------------------------------------------------------
            
            Console.WriteLine("Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.");
            Console.WriteLine();    

            int n = new Random().Next(10,99);
            Console.WriteLine ("рандомное число : " + n);

            int a = n % 10;
            int b = n / 10;
            if ( a < b ) Console.WriteLine("наибольшая цифра рандомного числа : " + b ); 
            else Console.WriteLine ( "наибольшая цифра рандомного числа : " + a );
            
            Console.WriteLine();
         //-------------------------------------------------------------------------------------------------------  
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        
        }
    }

    if ( q==8 )
    
    {
     
        int c8 = 1;
        while (c8==1)

        {

         //8.  Удалить вторую цифру трёхзначного числа.--------------------------------------------------------------------
            
            Console.WriteLine("Удалить вторую цифру трёхзначного числа.");
            Console.WriteLine();    

            Console.Write ("Введите число : ");
            int n = int.Parse( Console.ReadLine() );

            int a = n % 10;
            int b = n / 100;
                b = b * 10;
                n = a + b;

            Console.WriteLine("полученное число : " + n );
            
            
            Console.WriteLine();
         //-------------------------------------------------------------------------------------------------------  
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        
        }
    }

    if ( q==9 )
    
    {
     
        int c9 = 1;
        while (c9==1)

        {

         //9.  Выяснить, кратно ли число заданному, если нет, вывести остаток.--------------------------------------------------------------------
            
            Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток.");
            Console.WriteLine();    

            Console.Write ("Введите первое число : ");
            int n = int.Parse( Console.ReadLine() );

            Console.Write ("Введите второе число для проверки кратности : ");
            int m = int.Parse( Console.ReadLine() );


            n = m % n;
            if (n == 0) Console.Write("второе число кратно первому");
            else Console.Write ("второе число не кратно первому, остаток : " + n);
                   
            Console.WriteLine();
         //-------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        
        }
    }

    if ( q==10 )
    
    {
     
        int c10 = 1;
        while (c10==1)

        {

         //10. Найти третью цифру числа или сообщить, что её нет.--------------------------------------------------------------------
            
            Console.WriteLine("Найти третью цифру числа или сообщить, что её нет.");
            Console.WriteLine();    

            Console.Write ("Введите число : ");
            int n = int.Parse( Console.ReadLine() );

            
                if ( (n / 10) < 10 ) 
                {
                    Console.WriteLine("в данном числе нет третьей цифры");
                }
                else
                {
                    int m = 0;
                    int a = 0;
                    int b = 0;
                    int c = 0;

                    while ( n > 0 )
                    {  
                        m = n % 10; 
                        n = n / 10;
                        c = b;
                        b = a;
                        a = m;
                    }
                    Console.WriteLine("третья цифра в данном числе : " + c );
                }
            
            Console.WriteLine();
         //-------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.Write ("для выхода введите '0', для продолжения '1': ");
            int e = int.Parse( Console.ReadLine() );
            Console.Clear();
            if ( e == 0 ) break; 
        
        }
    }
}   

    


