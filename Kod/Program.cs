string Prompt(string mes) // вывод текста 
{
    Console.WriteLine(mes);
    return Console.ReadLine();
}

string[] FillArray(int size) // заполнение массива
{
    string[] array = new string[size]; // новый массив
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Write {i} element: ");
    }

    return array;
}

int CountWordsWithLessThan3Symbols(string[] array)
{
    int count = 0;
    foreach (string str in array) // оператор перебора массивов
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CopyOnlyLessThan3Symbols(string[] initialArr)
{
    int copySize = CountWordsWithLessThan3Symbols(initialArr);
    string[] newArr = new string[copySize];

    int count = 0;
    foreach (string str in initialArr)
    {
        if (str.Length <= 3)
        {
            newArr[count++] = str;
        }
    }

    return newArr;
}

void ShowArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int size = Int32.Parse(Prompt("Size of array: "));
string[] arr = FillArray(size);
string[] duplicate = CopyOnlyLessThan3Symbols(arr);
ShowArr(duplicate);
