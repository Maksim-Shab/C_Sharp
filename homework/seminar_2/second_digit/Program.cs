// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if(num / 100 < 1) {
    Console.Write("Вы ввели не техзначное число");
    return;
} else if(num / 100 > 10) {
    Console.Write("Вы ввели не техзначное число");
    return;
}
string n = num.ToString();
Console.Write("Вторая цифра введенного числа: " + n[1]);