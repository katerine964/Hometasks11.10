// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int m=0;
while (n>0)
{
    m=m+n%10;
    n=n/10;
}
Console.WriteLine("Сумма цифр данного числа равна "+m);