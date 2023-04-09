//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76
double[] array = new double [arrayLenght("введите длинну массива")];
RandomArray (array);
double morenumber = more(array);
double lessernumber = lesser(array);
double difference = morenumber - lessernumber;
System.Console.WriteLine("");
System.Console.WriteLine($"Меньшее число массива равно {lessernumber}");
System.Console.WriteLine($"Большее число массива равно {morenumber}");
System.Console.WriteLine($"Разность между max и min элементами массива равна: {Math.Round(difference, 2)}");


double lesser (double[] array)
{
    double lesser = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (lesser > array[i]) lesser = array[i];
    }
    return lesser;
}


double more (double[] array)
{
    double more = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (more < array[i]) more = array[i];
    }
    return more;
}

int arrayLenght (string i)
{
    System.Console.Write($"Введите {i} : ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

double RandomArrayRange (string i)
{
    System.Console.Write($"Введите {i} : ");
    double x = double.Parse(Console.ReadLine());
    return x;
}

double[] RandomArray (double[] array)
{
    double a = RandomArrayRange("нижний диапазон массива");
    double b = RandomArrayRange("верхний диапазон массива");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(b-a)+a, 2);
        System.Console.Write($"{array[i]} ");
    }
    return array;
}