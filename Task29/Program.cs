// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
   Console.WriteLine("Введите элемент массива с номером "+ i);
   array[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ",array)}]");