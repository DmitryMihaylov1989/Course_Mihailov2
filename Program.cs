//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.WriteLine();
Console.WriteLine("наш первый вариант массива:");
Console.WriteLine();
string[] array = new string[] {"array", "1234", "is", "course", "Denmark", "sum", "England", "for", ":)"};
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void Smallarr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string elem = arr[i];
        if (elem.Length <= 3)
        {
            arr[i] = elem;
    }
        else arr[i] = string.Empty;
    }
} 

PrintArr(array);
Smallarr(array);
Console.WriteLine();
Console.Write("итог - элементы меньше 4х символов: ");
PrintArr(array); 
Console.WriteLine();
