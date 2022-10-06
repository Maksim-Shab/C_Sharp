// seminar_6

int name = 41;

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
            Console.WriteLine("Введенные вами числа: " + "[" + String.Join(",", array) + "]");
            Array.Resize(ref array, array.Length + 1);
        }
        }
        catch{
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
    Console.WriteLine("Kоличество значений больше '0' равно: " + positiveNumbers);
   
    break;
 }
