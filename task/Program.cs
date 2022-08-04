/* Написать программу, которая из имеющегося массива формирует массив строк
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма.
["hello","2","world",":)"] -> ["2",":)"]
["1234","1567","-2","computer scince"] -> ["-2"]
["Russia","Denmark","Kazan"] -> [] */

string[] array1 = new string[5] {"hello", "Kazan","-2", "world", ":)",};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
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
NewArray(array1, array2);
PrintArray(array2);
