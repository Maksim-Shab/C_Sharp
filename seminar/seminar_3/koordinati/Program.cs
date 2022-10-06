Console.WriteLine("Введите x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y:");
int y = int.Parse(Console.ReadLine());

void FindChevert(int x, int y){
    
if(x > 0 && y > 0) {
   Console.WriteLine("1");
}
if(x < 0 && y > 0) {
   Console.WriteLine("2");
}
if(x < 0 && y < 0) {
   Console.WriteLine("4");
}
else {
   Console.WriteLine("1");
}
}