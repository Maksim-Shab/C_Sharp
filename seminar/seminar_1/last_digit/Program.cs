Console.Clear();
Console.Write("Введите техзначное число: ");
int num = int.Parse(Console.ReadLine());
if(num / 100 < 1) {
    Console.Write("Вы ввели не техзначное число");
    return;
} else if(num / 100 > 10) {
    Console.Write("Вы ввели не техзначное число");
    return;
}
Console.Write(num % 10);

// Console.Clear();
// Console.Write("Введите техзначное число: ");
// int num = Convert.ToIn32(Console.ReadLine());

// int num_dec = num - (num / 100) * 100;
// int num_l = num - (num_dec / 10) * 10;

// Console.Write(num_l);