Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
FillArray(array);
PrintArray(array);

int newSize = 0;
string[] newArray = new string[size];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        newArray[newSize] = array[i];
        newSize++;
    }
}

Array.Resize(ref newArray, newSize);
PrintArray(newArray);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
