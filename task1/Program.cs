while (true)
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    int number;
    if(int.TryParse(text, out number)) // веденное значение состоит из цифр
    {
        Console.WriteLine("Введенная строка состоит из цифр");
        int sum = 0;
        while (number > 0)
        {
            sum = sum + number%10;
            number/=10;
        }
        if (sum%2==0)
        {
            break;
        }
    }
}