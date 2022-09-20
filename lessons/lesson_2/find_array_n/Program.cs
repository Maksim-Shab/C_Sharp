int[] array = {1,2,3,4,5,6,7,8,9,2,34,4,456734,74,8567,45236,};
int n = array.Length;
int find = 456734;
int i = 0;

while(i < n) {
    if(array[i] == find) {
        Console.WriteLine(i);
        break;
    }
    i++;
}