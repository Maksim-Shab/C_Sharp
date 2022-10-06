// Введите номер задачи!
int name = 25;

switch(name) {

    case (19):

    // Напишите программу, которая принимает на вход пятизначное число и проверяет,
    // является ли оно палиндромом.
        Console.Clear();

        Console.WriteLine("Введите пятизначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
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

    case(24):

    // Напишите программу, которая на вход принимает радиус круга
    // и находит его площадь округленную до целого числа,
    // необходимо вывести максимальную цифру
    // в полученном округлённом значении площади круга.
    // 10 -> 4
    // 20 -> 7
    // 30 -> 8

    Console.Clear();

    Console.WriteLine("Введите радиус круга: ");
    int radius = Convert.ToInt32(Console.ReadLine());
    double S = 3.14 * (Math.Pow(radius, 2));

    Console.WriteLine(Math.Round(S));

    break;

    case (25):
    // Напишите программу, которая на вход принимает букву,
    // необходимо создать массив из 5 названий городов,
    // и вывести на экран те (тот), где чаще всего встречается введённая
    // буква.
    // Введённая буква: "о",
    // массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"

    Console.Clear();
    
    var array = new string[] {"Барнаул", "Кемерово", "Тюмень", "Новосибирск", "Манжерок"};
    Console.WriteLine("Введите букву: ");
    string letter = Console.ReadLine();
   
   int numLetter = 0;
   for (int i = 0; i < array.Length; i++){
        int max = 0;
        string city = array[i];
        for (int j = 0; j < city.Length; j++){
            if(letter == city[j]){
                numLetter ++;
                if(numLetter > max) {
                    max = numLetter;
                }
            }
            
        }
   }

   System.Console.WriteLine(letter); 
    

    break;
}