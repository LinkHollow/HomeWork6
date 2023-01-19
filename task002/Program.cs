// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6) в промежутке от 0 до 100,
//  а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
System.Console.WriteLine("Введите размерность массива(не менее 6): ");
int X = Convert.ToInt32(Console.ReadLine());
if(X < 6)
{
    System.Console.WriteLine("Введена неверная размерность");
}
else
{
    int[] MyArray = GetArray(X, 0, 100);
    Console.WriteLine($"[{String.Join(" ", MyArray)}]");
    Console.WriteLine($"[{String.Join(" ", SortArray(MyArray))}]");
}



// ------------------Method----------------------
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] SortArray(int[] Array)
{
    for (int i = 0; i < Array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[j] < Array[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = Array[i];
        Array[i] = Array[minPosition];
        Array[minPosition] = temp;

    }
    return Array;
}
