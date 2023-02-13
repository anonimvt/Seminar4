int numberA = InputInt("Введите число: ");
int numberB = InputInt("Введите степень: ");
Stepen(numberA, numberB);


// Функция возведения в степень
void Stepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в " + b + "степени равно: " + result);
}

// Функция ввода данных с предварительном выводом сообщения
int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}