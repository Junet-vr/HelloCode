// string Method4(int count, string text)
// {
//     string result = String.Empty;
// for( int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// //Console.WriteLine(res);

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//        Console.Write($"{i} х {j} = {i * j}\t");
//     }
//    Console.WriteLine();
// }




void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[maxPosition]) 
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    
}


int[] arr = {1, 1, 4, 6, 8, 9, 3, 6, 5};

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);



