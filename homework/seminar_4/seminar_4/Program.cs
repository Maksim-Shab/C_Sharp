// Введите номер задачи!
int name = 27;

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
        Console.WriteLine($"Результатом возведения числа {a} в степень {b}, является: {VozInPow(a, b)}.");
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
}