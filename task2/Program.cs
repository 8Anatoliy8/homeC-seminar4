int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int FindEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Ввведите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N, 100, 999);
Console.WriteLine($"Массив: [ {string.Join("; ", res)}]");
Console.WriteLine($"Количество четных чисел в массиве: {FindEvenNumbers(res)}");