




// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равнв 3 символам.
// Первоначальный массив можно ввести с клавиатурыБ либо задать на старте выполнения алгоритма.
// При решении не стоит пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"]  -->  ["2", ":-)"]
// ["1234", "1567", "-2" "computer science"]  -->  ["-2"]
// ["Russia", "Denmark", "Kazan"]  -->  []



string[] readArray = new string[] { "hello", "2", "world", ":-)" };
string[] controlArray = new string[readArray.Length];

PrintArray(readArray);
CountSymbols(readArray, controlArray);
PrintArray(controlArray);



void PrintArray(string[] useArray)
{
    for (int i = 0; i < useArray.Length; i++)
    {
        System.Console.Write($"{useArray[i]}  ");
    }
    System.Console.WriteLine();
}

void CountSymbols(string[] readArray, string[] controlArray)
{
    int count = 0;
    for (int i = 0; i < readArray.Length; i++)
    {
        if (readArray[i].Length <= 3)
        {
            controlArray[count] = readArray[i];
            count++;
        }
    }
}