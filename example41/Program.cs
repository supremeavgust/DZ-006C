// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



void InputArray(int[] array)
{
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"number= ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

}
void PrintArray(int[] array)
{
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] > 0)
                sum += 1;
        }
        Console.WriteLine(sum);

    }

}
Console.Clear();
Console.Write($"Введите сколько чисел вам надо: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);


