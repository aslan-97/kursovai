string[] array = {"1, 12, abcd, =), 12345, 674"};
var massiv = new string[array.Length];
int j = 0;
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    massiv[j] = array[i];
    j++;
}
Console.WriteLine($"[{string.Join(", ", massiv[j])}]");
//Console.WriteLine($"значение менее 3 элементов: {massiv[j]}");
}






