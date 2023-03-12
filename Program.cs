//объявляется два массива: изначальный и второй такой же длины.
string[] array1 = new string[5] {"un", "doi", "trei", "patru", "unsprezece"}; 
string[] array2 = new string[array1.Length];
// объявляется метод, в котором проверяется условие ( <=3 )
void SecondArrayWithIF(string[] array1, string[] array2)
{ // переменная count для поочередного закидывания из первого массива во второй
    int count = 0;
    // после присвоения переменная count увеличивается на 1 и возвращается к циклу for, 
    //в котором i также увеличивается на 1
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
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
SecondArrayWithIF(array1, array2);
PrintArray(array2);