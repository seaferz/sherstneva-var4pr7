/*Дана непустая последовательность целых чисел, оканчивающаяся -5. Найти: 
а)количество четных чисел последовательности; б)количество положительных чисел 
последовательности.*/

Console.WriteLine("Введите числа (последовательность заканчивается -5):");

int countEven = 0; // Количество четных чисел
int countPositive = 0; // Количество положительных чисел
int number;

do
{
    number = int.Parse(Console.ReadLine());
    if (number == -5)
        break; // Завершение последовательности

    // Проверка на четность
    if (number % 2 == 0)
    {
        countEven++; 
    }
    if (number > 0) // Проверка на положительность
    {
        countPositive++;
    }
} while (true);

//вывод
Console.WriteLine($"Четных чисел: {countEven}");
Console.WriteLine($"Положительных чисел: {countPositive}");