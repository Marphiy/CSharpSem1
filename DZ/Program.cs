// Для запуска конкретной задачи раскомментируйте соответствующий point (строки 65 - 68) внизу!

void Point2()
{
    Console.WriteLine("Введите число 'a':");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 'b':");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b) Console.WriteLine(a + " больше " + b);
    else Console.WriteLine(b + " больше " + a);
}

void Point4()
{
    Console.WriteLine("Введите число 'a':");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 'b':");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 'c':");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine("Максимальное число = " + max);
}

void Point6()
{
    Console.WriteLine("Введите целое число:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 != 0) Console.WriteLine("Число " + num + " НЕчетное");
    else Console.WriteLine("Число " + num + " четное");
}

void Point8()
{
    Console.WriteLine("Введите целое число:");
    int num = Convert.ToInt32(Console.ReadLine());
    int start = 2;
    if (num > 0)
    {
        Console.Write("Четные числа от 1 до " + num + ": ");
        while (start < num)
        {
            Console.Write(start + " ");
            start += 2;
        }
        Console.WriteLine();
    }
    else
    {
        start = 0;
        Console.Write("Четные числа от 1 до " + num + ": ");
        while (start > num)
        {
            Console.Write(start + " ");
            start -= 2;
        }
        Console.WriteLine();
    }
}



//Point2();
//Point4();
//Point6();
//Point8();
