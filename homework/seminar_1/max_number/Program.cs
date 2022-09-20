// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Clear();
Console.WriteLine("Введите два разных числа: ");
int fierst_num = int.Parse(Console.ReadLine());
int second_num = int.Parse(Console.ReadLine());
int max = fierst_num;
if(fierst_num < second_num) {
    max = second_num;
    int min = fierst_num;
    Console.Write("Максимальное значение: " + max + " Минимальное значение: " + min);
}