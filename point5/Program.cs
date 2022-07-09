Console.Write("Вевдите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат числа " + number + " = " + Power(number));

int Power(int num1)
{
    return num1 * num1;
}