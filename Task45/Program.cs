int[] GetArray(string[] input)
{
    int[] array = new int[input.Length];
    for(int i = 0; i < input.Length; i++)
    {
        array[i] = int.Parse(input[i]);
    }
    return array;
}
int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}
Console.Clear();
Console.Write("Введите числа массива через пробел: ");
string[] InputArray = Console.ReadLine().Split(' ');
int[] Array = GetArray(InputArray);
Console.Write($"Исходный массив: {String.Join(" ", Array)}");
Console.WriteLine();
int[] NewArray = CopyArray(Array);
Console.Write($"Копия массива: {String.Join(" ",NewArray)}");