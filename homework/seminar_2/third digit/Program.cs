// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число(которое должно быть не меньше 100!): ");
int num = int.Parse(Console.ReadLine());
if(num / 100 < 1) {
    Console.Write("У заданного числа третьей цифры нет!");
    return;
}
string n = num.ToString();
Console.Write("Третья цифра введенного числа: " + n[2]);