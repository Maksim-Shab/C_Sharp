// seminar_6


switch(6){

    case(1):

    int[] array = FillArray(5,1,10);

    Console.WriteLine("Заданный массив: " + "[" + String.Join(",", array) + "]");
    Console.WriteLine("1 способ: Перевернутый массив: " + "[" + String.Join(",", ReversArray(array)) + "]");
    Console.WriteLine($"2 способ: Перевернутый массив: " + "[" + String.Join(",", array.Reverse()) + "]");

    int[] FillArray(int size, int min, int max) {
        int[] fillArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            fillArray[i] = new Random().Next(min, max + 1);
        }
        return fillArray;
    }

    int[] ReversArray(int[] inputArray) {
        int[] reversArray = new int[inputArray.Length];

                    //Первый вариант разворота:

        // for (int i = 0; i < inputArray.Length; i++)
        // {
        //     reversArray[i] = inputArray[inputArray.Length - 1 - i];
        // }

                    //Второй вариант разворота:

        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            reversArray[inputArray.Length - 1 - i] = inputArray[i];
        }
        return reversArray;
    }

    break;

    case(2):

    Console.Clear();

    Console.WriteLine("Введите сторону А: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите сторону B: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите сторону C: ");
    int c = Convert.ToInt32(Console.ReadLine());

    int max = a;
    int min_1 = 0;
    int min_2 = 0;

    if(max <= b) {
        max = b;
        min_1 = a;
    } 
    Console.WriteLine(min_1);
        
    if(max <= c) {
        max = c;
        min_2 = b;
    }

    Console.WriteLine("Min_1 = " + min_1);
    Console.WriteLine("Min_2 = " + min_2);
    Console.WriteLine("Max = " + max);
    
    if(max >= (min_1 + min_2)){
        Console.WriteLine("Введенные значения не позваляют создать треугольник!");
    } else {
        Console.WriteLine("Введенные значения позваляют создать треугольник!");
    }

    break;

    case(3):

    Console.Clear();

    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine()); 
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
    Console.WriteLine('[' + String.Join(",", arr) + "]");

    break;

    case(4):
    // Напишите программу, которая будет преобразовывать десятичное число
    // в двоичное.
    // 45 -> 101101
    // 3  -> 11
    // 2  -> 10

    Console.Clear();

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string str = String.Empty;
    while(number > 0) {
        str = number % 2 + str;
        number /= 2;
    }
    Console.WriteLine(str);
            // Мой вариант
    // int[] ar = new int[1];

    // for (int e = 0; 0 < number; e++)
    // {
    //     int j = number % 2;
    //     number = number / 2;
    //     ar[e] = j;
    //     // Console.WriteLine(j + ", " + number + "[" + String.Join(",", ar) + "]");
    //     Array.Resize(ref ar, ar.Length + 1);
    // } 
    // Array.Resize(ref ar, ar.Length - 1);
    // Array.Reverse(ar);
    
    // Console.WriteLine("Введенное число в двоичной системе будет выглядеть так: " + "[" + String.Join(",", ar) + "]");
   

    break;

    case(5):

    Console.Clear();
    Console.WriteLine("Введите число: ");
    int num2 = int.Parse(Console.ReadLine());
    
    int[] arra = new int[num2];
    arra[0] = 0;
    arra[1] = 1;

    for (int i = 2; i < num2; i++)
    {
        arra[i] = arra[i-1] + arra[i-2];
    }

    Console.WriteLine("Фибоначи: " + String.Join(",", arra));

    break;  
}