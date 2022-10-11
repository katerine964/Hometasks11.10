// See https://aka.ms/new-console-template for more information
Console.Clear();
int max1=0;
int max2=0;
Console.WriteLine("Введите количество элементов последовательности не превышающее 100: ");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число под номером "+(i+1));
    int n = Convert.ToInt32(Console.ReadLine());
    if(n > max1)
    {
        max2=max1;
        max1=n;
    }
    if(n<max1 && n>=max2)
    {
        max2=n;
    } 
    if(n==0)
        break;
}
Console.WriteLine("второй максимум "+max2);
