// seminar_9

int name = 4;

switch (name) {

    case(1):
    // Задайте значение N. Напишите программу,
    // которая выведет все натуральные числа в промежутке от 1 до N
    // с помощью рекурсии
    // N = 5 -> "1, 2, 3, 4, 5"
    // N = 6 -> "1, 2, 3, 4, 5, 6"


    Console.Clear();
    Console.WriteLine("Введите число 'N': ");
    int n = Convert.ToInt32(Console.ReadLine());
    int x =1;
    Recurs();

    void Recurs(){ 
        if(x <= n){
            Console.Write((x++) + " ");
            Recurs();
        }
    }

    break;

    case(2):
    // Задайте значения M и N. Напишите программу,
    // которая выведет все натуральные числа в промежутке от M до N
    // с помощью рекурсии
    // M = 1; N = 5 -> "1, 2, 3, 4, 5"
    // M = 4; N = 8 -> "4, 5, 6, 7, 8"

    Console.Clear();

    Console.Write("Введите число М: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число Z, оно должно быть больше чем М: ");
    int z = Convert.ToInt32(Console.ReadLine());
    
    if(m > z){
        Console.WriteLine("Введите другие числа.");
    } else{
        Recurs1();        
    }

    void Recurs1()
    {
        if(m<=z){
            System.Console.Write((m++) + " ");
            Recurs1();
        }
    }

    break;

    case(3):
    // Напишите программу, которая будет принимать на вход число
    // и возвращать сумму его цифр с помощью рекурсии.
    // 453 -> 12
    // 45 -> 9

    Console.Clear();

    Console.Write("Ведите число от двух символов: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int summ = 0;

    if((num / 10) <= 0){
        Console.WriteLine("Введите другое число");
    } else if(num / 10 > 0) {
        Console.WriteLine("Результатом сложения цифр будет: " + Recurs2());    
    }
    
    int Recurs2(int num){
        if(num > 0){
            summ += num % 10;
            Recurs2(num / 10);
        }
        return summ;
    }
    
    break;

    case(4):
    // Напишите программу, которая на вход принимает два числа A и B,
    // и возводит число А в целую степень B с помощью рекурсии.
    // A = 3; B = 5 -> 243 (3⁵)
    // A = 2; B = 3 -> 8

    Console.Clear();

    Console.Write("Введите число А: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число 'А' в степени 'В' равно: " + Recurs3(a,b));

    int Recurs3(int A, int B){
        if(B == 0) return 1;
        return A * Recurs3(A, B -1);
    }

    break;

}