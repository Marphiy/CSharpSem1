void point5()
{
    Console.WriteLine("Введите любое целое число!");
    int number = Convert.ToInt32(Console.ReadLine());
    int start = -number;
    while (start <= number)
    {
        Console.Write(start + " ");
        start ++;
    }
    Console.WriteLine();
}

point5();