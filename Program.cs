//To have different sized arrays, we ask to put array elements from user
Console.WriteLine ("Введите значения массива через пробел:");
string[] imputArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Вводный массив:");

// Method, to print massives within this task
void PrintStringArray (string[] imput)
{

    Console.Write ("=> [ ");
    for (int i = 0; i < imput.Length; i++)
    {
        Console.Write (imput[i] + " ");
    }
    Console.Write ("]");
}

// Printing imput array
PrintStringArray (imputArray);
Console.WriteLine();

//Here we shall put our resulting elements
string[] resultArray = new string[imputArray.Length];

// Method to put our needed elements in another array and remove empty
void FindSmallStringsAndFillResultArray(string[] imput, string[] result, int ind = 0)
{
    for (int i = 0; i < imput.Length; i++)
    {

        if (imput[i].Length <= 3)
        {
            result[ind] = imput[i];
            ind++;
        }
    }
    if (ind > 0)
    {
        Array.Resize(ref result, ind);
        PrintStringArray(result);
    }
    else { Console.Write("=> [ Результатов нет. ]");}
}

Console.WriteLine("Массив результата:");
FindSmallStringsAndFillResultArray(imputArray, resultArray);