Console.WriteLine("Введите массив:");
string[] input = Console.ReadLine().Split();
int count = 0;
for (int i=0; i<input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        count++;
    }
}
string[] array = new string[count];
int j = 0;
for (int i=0; i<input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        array[j] = input[i];
        j++;
    }
}
foreach (string element in array)
{
    Console.Write(element + " ");
}