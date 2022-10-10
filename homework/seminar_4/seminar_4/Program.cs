// Введите номер задачи!
int name = 31;

switch (name) {

    case (25):

    // Напишите цикл, который принимает на вход два числа (A и B)
    // и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    Console.Clear();

    int y = 1;

    double VozInPow(int a, int b){
        double result = Math.Pow(a,b);
        return result;
    }
    while(y != 0) {
        Console.WriteLine("Нажми '0', если хочешь выйти из программмы! Или любую другую цифру, для продолжениея процесса");
        y = Convert.ToInt32(Console.ReadLine());
    
        if(y != 0) {
        Console.WriteLine("Введите число, которое будем возводить в степень:");
        int a = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Введите степень:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результатом возведения числа '{a}' в степень '{b}', является: {VozInPow(a, b)}");
        } else {
        break;
        }
    }

    break;

    case(27):
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12

    Console.Clear();


    Console.WriteLine("Введите число, что-бы посчитать сумму цифр: ");
    int number = int.Parse(Console.ReadLine());
    int numberLength = Convert.ToString(number).Length;
    int numberSumm = 0;
    int remains = 0;

    int Result(){
        for (int i = 0; i < numberLength; i++)
        {
            remains = number % 10;
            numberSumm = numberSumm + remains;
            number = (number - remains) / 10;
        }
        return numberSumm;
    }

    Console.WriteLine($"Суммой цифр числа '{number}' является: {Result()}");

    break;


    case(29):
    // Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]

    Console.Clear();

    Console.WriteLine("Введите длину массива: ");
    int length_mass = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length_mass];

    int[] Massiv(int length_mass){
        for (int i = 0; i < length_mass; i++)
        {
            array[i] = new Random().Next(-100, 100 +1);
        }
        return array;
    }

    void PrintArray(int[] arr){
        Console.WriteLine("[" + String.Join(",", array) + "]");
    }

    PrintArray(Massiv(length_mass));

    break;

    case(30):
    // Напишите программу, которая задаёт массив из 10 элементов,
    // которые необходимо заполнить случайными значениями
    // в диапазоне от -10 до 10 и найти максимальное значение среди них.
    // [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
    // [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
    // [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

    Console.Clear();

    int[] array1 = new int[10];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-10, 10);
    }
    Console.Write("Массив: [" + String.Join(",", array1) + "]");
    System.Console.WriteLine();
    int max = array1[0];
    for (int i = 1; i < array1.Length; i++)
    {
        if(max < array1[i]) {
            max = array1[i];
        }
    }
    Console.WriteLine("Макимальное значение в массиве: " + max);

    break;

    case(31):
// Напишите программу, которая задаёт 2 одномерных массива из N элементов
// которые заполняются случайными значениями в диапазоне от 1 до 10
// и находит среднее арифметическое элементов этих 2 массивов,
// далее от большего из получившихся средних арифметических отнимаем меньшее
// и округлённый до целого числа результат переводим
// в двоичную систему счисления.
// [1,2,3,4] [3,6,4] -> округлённая до целого числа разница между средними
// арифметическими массивов = 2. 2 в двоичной системе счисления = 10
// [4,7,9] [3,3,1,2,2] -> округлённая до целого числа разница между средними
// арифметическими массивов = 4. 4 в двоичной системе счисления = 100

    Console.Clear();

    int[] firstArray = Fillarray(3);
    int[] secondArray = Fillarray(3);
    PrintArray1(firstArray);
    PrintArray1(secondArray);
    Transfer(firstArray, secondArray);

    int[] Fillarray(int n){
        int[] fillArray = new int[n];
        for (int i = 0; i < fillArray.Length; i++)
        {
            fillArray[i] = new Random().Next(1, 10);
        }
        return fillArray;
    }

    void PrintArray1(int[] array) {
        Console.Write("Массив: [" + string.Join(",", array) 
        + "] - среднее арифметическое: " + Average(array));
        Console.WriteLine();
    }

    double Average(int[] array) {
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average = average / array.Length;
        return average;
    }

    void Transfer(int[] arr1, int[] arr2) {
        int n = 0;
        if(Average(arr1) > Average(arr2)){
            n = Convert.ToInt32(Math.Round(Average(arr1) - Average(arr2), 0));
            Console.WriteLine("Результат вычитания из большего значения меньшего: " + n);
        } else {
            n = Convert.ToInt32(Math.Round(Average(arr2) - Average(arr1), 0));
            Console.WriteLine("Результат вычитания из большего значения меньшего: " + n);
        }
        
        string str = "";
        for(int i = 0; n > 0; i++) {
            str = n % 2 + str;
            n /= 2;
        }
        Console.Write("В двочной системе резельтат выглядет так: " + str);    

    }
   
    break;
}
