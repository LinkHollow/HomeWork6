// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Для строки можно использовать данный метод 
// string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)(пользователь вводит в консоли числа через пробел и они формируют строку)

System.Console.WriteLine("Введите числа через пробел: ");
string StringArray = Console.ReadLine()!;
string[] numS = StringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] number = numS.Select(int.Parse).ToArray();

System.Console.WriteLine($"Чисел строго больше 0 = {ArraySt(number)}");

//----------------------Method-----------------------

int ArraySt(int[] Array)
{
    int count = 0;
    foreach (int el in Array)
    {
        if (el > 0)
        {
            count++;
        }
    }
    return count;
}