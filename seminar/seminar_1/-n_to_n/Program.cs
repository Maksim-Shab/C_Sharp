Console.Clear();
Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
double num_neg = -num;
while(num_neg <= num) {
    Console.Write(num_neg + " ");
    num_neg++;
}