//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[number("длинну массива")];
RandomArray(array);
System.Console.WriteLine(" ");
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sum (array)}");


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
        array[i] = new Random().Next(-100, 101);
        System.Console.Write($"{array[i]} ");
    }
    return array;
}

int sum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = array[i] + sum;
    }
    return sum;
}