int name = 19;

switch(name) {
    case (19):
    // Напишите программу, которая принимает на вход пятизначное число и проверяет,
    // является ли оно палиндромом.

        Console.Clear();
        Console.WriteLine("Введите пятизначное число: ");
        int num = int.Parse(Console.ReadLine());
        string s = num.ToString();
        int i = 0;
        int mas = s[i];
        int n = s.Length;
        // Console.WriteLine(s.Length);
        if(s.Length == 5) {
            if(s[i] != s[n - 1]) {
                Console.WriteLine("Введеное число не является палиндромом!");
            } 
            else {
                while(i < n / 2) {
                    if(s[i] == s[n - 1]) {
                        i++;
                        n--;
                    }
                }
            Console.WriteLine("Введеное число является палиндромом!");     
            }     
        } else {
        Console.WriteLine("Введено не пятизначное число!");
        }


    break;    
}