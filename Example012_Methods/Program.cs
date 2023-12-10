// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();


//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);

//Вид 3

//int Method3()
//{
//    return DataTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);

//Вид 4 
//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;

//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} х {j} = {i * j}");
    }
    //Console.WriteLine();
}


// Дан текст. В тексте нужно все пробелы черточками, малинькие буквы "к" заменить "К",
// а большие "С" заменить маленькими "с".


//ясна ли задача?

string text = " какой - то текст "
            + "Какие - то буквы "
            + "Смотрим что вышло ";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);