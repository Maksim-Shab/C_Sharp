// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введи число и я выведу тебе все четные значения этого числа: ");
double num = Convert.ToDouble(Console.ReadLine());
double num_new = 2;
while(num_new <= num) {
    if(num_new % 2 == 0)
    Console.Write(num_new + " ");
    num_new++;
}git 