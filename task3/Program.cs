int[] arr = {11, 22, 33, 44, 55, 66};
Console.Write("Массив: ");
for (int i = 0; i < arr.Length; i++)
{
   Console.Write($"{arr [i]} "); 
}
int temp;
for (int i = 0; i < arr.Length/2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
Console.Write ("\nПеревернутый масив: ");
for (int i = 0; i < arr.Length; i++)
{
   Console.Write($"{arr [i]} "); 
}