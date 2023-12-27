﻿string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
void ResArray(string[] array1, string[] array2)
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

void WriteArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

ResArray(array1, array2);
WriteArray(array2);