int[] GetArray(string[] input)
{
    int[] array = new int[input.Length];
    for(int i = 0; i < input.Length; i++)
    {
        array[i] = int.Parse(input[i]);
    }
    return array;
}
int CountPos(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.Clear();
Console.Write("Введите числа массива через пробел: ");
string[] InputArray = Console.ReadLine().Split(' ');
int[] Array = GetArray(InputArray);
Console.Write($"Исходный массив: {String.Join(" ", Array)}");
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел в массиве: {CountPos(Array)}");