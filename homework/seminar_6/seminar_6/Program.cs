// seminar_6

int name = 43;

 switch(name) {

    case(41):

    // Пользователь вводит с клавиатуры M чисел.
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3

    Console.Clear();

    int[] array = new int[1];
   
    for (int i = 0; i <= int.MaxValue; i++)
    {
        try {
        if(array[i] <= int.MaxValue) {
            Console.WriteLine("Введите число и нажмите 'Enter': ");
            Console.WriteLine("!!!Если хотите прервать ввод чисел, введите любую букву или 'Enter'!!!");
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number;
            Console.Clear();
            Console.WriteLine("Введенные вами числа: " + String.Join(",", array));
            Array.Resize(ref array, array.Length + 1);
        }
        }
        catch{
            Console.Clear();
            break;
        }    
    }
    Array.Resize(ref array, array.Length - 1);
   
    int positiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) {
            positiveNumbers ++;
        }
    }
    Console.WriteLine("Введенные вами числа: " + String.Join(",", array));
    Console.WriteLine("Kоличество значений больше '0' равно: " + positiveNumbers);
   
    break;

    case(43):

    // Напишите программу, которая найдёт точку пересечения двух прямых,
    // заданных уравнениями
    // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
    // задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    Console.Clear();

    Console.WriteLine("Введите значение 'b1': ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение 'k1': ");
    double k1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение 'b2': ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение 'k2': ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = -(b2 - b1) / (k2 - k1);
    double y = k2 * x + b2;

    Console.WriteLine("Прямые пересекаються в точке с координатами Х: " + x + ", Y: " + y);

    break;
 }
