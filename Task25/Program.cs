// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Bведите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bведите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c=1;
for (int i = 0; i < b; i++)
{
    c=c*a;
}
Console.WriteLine("число "+a+" в степени "+b+" равно "+c);