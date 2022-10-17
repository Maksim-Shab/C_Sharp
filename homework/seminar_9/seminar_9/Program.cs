// seminar_9

int name = 68;

switch(name){

    case(64):
    // Задайте значения N и M. Напишите программу,
    // которая выведет все чётные натуральные числа
    // в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 5 -> 2, 4
    // M = 4; N = 8 -> 4, 6, 8

    Console.Clear();

    EvenNaturalNumbers(4, 8);

    void EvenNaturalNumbers(int m, int n){
        if(m <= n){
            if(m % 2 == 0){
                Console.Write(m + " ");
            }
            m++;
            EvenNaturalNumbers(m, n);
        }
    }

    break;

    case(66):
    // Задайте значения M и N. Напишите программу,
    // которая найдёт сумму натуральных элементов
    // в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8 -> 30

    Console.Clear();

    int summ = 0;
    SummNaturalNumbers(1, 15);

    void SummNaturalNumbers(int m, int n){
        if(m > n){
            Console.WriteLine("Cуммa натуральных элементов: " + summ);
            return;
        }
        summ += m++;
        SummNaturalNumbers(m, n);
    }

    break;

    case(68):
    // Задайте значения M и N. Напишите программу,
    // которая найдёт наибольший общий делитель (НОД) этих чисел
    // с помощью рекурсии.
    // M = 28; N = 7 -> 7

    Console.Clear();
    
    Console.Write("Введите положительное число S: ");
    int s = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите положительное число D: ");
    int d = Convert.ToInt32(Console.ReadLine());
    Console.Write("Наибольший общий делитель введенных чисел: " + GreatestCommonDivisor(s,d));

    int GreatestCommonDivisor(int S, int D){
        int nod = 0;
        if(S == 0 || D == 0) return nod = S + D;
        if(S > D){
            S %= D;
        } else if(D > S){
            D %= S;
        }
        return GreatestCommonDivisor(S,D);
    }

    break;

}