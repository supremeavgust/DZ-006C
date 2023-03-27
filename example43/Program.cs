// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void InputArray(double[] array)
{

    for (int i = 0; i < 2; i++)
    {
        Console.Write($"b{i + 1}=");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    {
        for (int j = 2; j < 4; j++)
        {
            Console.Write($"k{j-1}=");
            array[j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");

}
void PrintArray(double[] array)
{

    double x = -(array[0] - array[1]) / (array[2] - array[3]);
    double y = array[2] * x + array[0];
    Console.WriteLine($"[{x};{y}]");
}
Console.Clear();
double[] array = new double[4];
InputArray(array);
PrintArray(array);




