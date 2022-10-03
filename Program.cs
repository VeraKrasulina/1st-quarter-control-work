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