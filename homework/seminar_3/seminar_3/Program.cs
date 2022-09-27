// Введите номер задачи!
int name = 19;

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



    break;
}