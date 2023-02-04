/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int InputInt(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        double num = Math.Round(random.NextDouble() * (100 - 1) + 1, 2);
        array[i] = num;
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item}\t ");
    }
    System.Console.WriteLine();
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int len = InputInt("Введите длину массива");
double[] array = CreateArray(len);
PrintArray(array);
double max = MaxElement(array);
double min = MinElement(array);
Console.WriteLine($"{max} - {min} = {Math.Round(max - min, 2)}");