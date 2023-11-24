string[] CreatFirstArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

string[] SortingThreeDigitNumbers(string[] firstArray, int size)
{
    string[] firstSortingArray = new string[size];
    int longArr = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            firstSortingArray[longArr] = firstArray[i];
            longArr++;
        }   
    }
    string[] sortingArray = new string[longArr];
    for (int j = 0; j < sortingArray.Length; j++)
    {
        sortingArray[j] = firstSortingArray[j];
    }
    return sortingArray;
}

// Написать удаление последних  не использованных строк!!!

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.Write("]");
}

Console.WriteLine("Сколько строк будет в массиве?");
int row = Convert.ToInt32(Console.ReadLine());
string [] firstArr = CreatFirstArray(row);
PrintArray(firstArr);
Console.Write(" => ");
string [] lastArr = SortingThreeDigitNumbers(firstArr, row);
PrintArray(lastArr);