Console.Clear();
Console.WriteLine("Введите последовательность строк, разделяя их пробелом: ");
string[] sourceArray = Console.ReadLine().Split(' ');
string[] targetArray = new string[sourceArray.Length];
Console.WriteLine("Исходный массив: ");
Console.WriteLine("[\"" + string.Join("\", \"", sourceArray) + "\"]");
int t = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        targetArray[t] = sourceArray[i];
        t++;
    }
}
Array.Resize(ref targetArray, t);
Console.WriteLine("Полученный массив: ");
Console.WriteLine("[\"" + string.Join("\", \"", targetArray) + "\"]");




