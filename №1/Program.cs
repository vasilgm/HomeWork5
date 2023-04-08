//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[number("длинну массива")];
RandomArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum = sum + NumberOfEven(array[i]);
}
System.Console.WriteLine(sum);




int number (string i)
{
    System.Console.Write($"Введите {i} : ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int[] RandomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write($"{array[i]} ");
    }
    return array;
}

int NumberOfEven (int Number)
{
    int x = (Number/100)%2; // Если первое число нечетное то х=1;
    int y = 1;
    if ((Number/10) % 10 != 0) y = (Number/10)%2; // Если второе число не равно нулю и нечетное то y=1;
    int z = 1;
    if (Number % 10 != 0) z = Number%2; // Если третье число не равно нулю и нечетное то z=1;
    return 3-x-y-z;
}