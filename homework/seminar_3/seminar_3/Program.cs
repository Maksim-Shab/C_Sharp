// Введите номер задачи!
int name = 23;

switch(name) {

    case (19):

    // Напишите программу, которая принимает на вход пятизначное число и проверяет,
    // является ли оно палиндромом.
        Console.Clear();

        Console.WriteLine("Введите пятизначное число: ");
        int num = int.Parse(Console.ReadLine());
        string s = num.ToString();
        int n = s.Length - 1;
        int j = 0;

        if(s.Length == 5) {
            for(int i = 0; i < s.Length / 2; i++) {
                if(s[i] != s[n]) {
                    j = 1;
                } 
                n--;                    
            }
            if(j == 1){
                Console.WriteLine("Введеное число не является палиндромом!");
            } else {
                Console.WriteLine("Введеное число является палиндромом!");        
            }
        } else {
        Console.WriteLine("Введено не пятизначное число!");
        }

    break;    


    case (21):

    // Напишите программу, которая принимает на вход координаты двух точек
    // и находит расстояние между ними в 3D пространстве

    Console.Clear();
    
    Console.WriteLine("Введи координату х точки А");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введи координату y точки А");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введи координату z точки А");
    int z1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введи координату х точки B");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введи координату y точки B");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введи координату z точки B");
    int z2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Длина отрезка: " + 
    Math.Sqrt(
        Math.Pow((x2 - x1),2) +
        Math.Pow((y2 - y1),2) +
        Math.Pow((z2 - z1),2)
        
    ));

    break;


    case (23):
    
    // Напишите программу, которая принимает на вход число (N)
    // и выдаёт таблицу кубов чисел от 1 до N.

    Console.Clear();

    Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());

    for(int e = 1; e <= a; e++) {
        Console.Write(Math.Pow(e , 3) + " ");
    }

    break;
}