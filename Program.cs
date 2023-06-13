//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
int n = GetPositivUserNumber("Введите количество элементов массива: ", "Ошибка ввода");
string[] array = GetArrayUser(n);

Console.WriteLine(String.Join("|", array));
string [] result=GetResult(array);
Console.WriteLine(String.Join("|", result));

string[] GetResult(string[] arr)
{   string[] rez=CreateNewArray(array);
    int j=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <=3)
            rez[j]=arr[i];
            j++;
    }
    return rez;
}

string[] CreateNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length  <= 3)
            count++;
    }
    string[] rez = new string[n];
    return rez;
}

string[] GetArrayUser(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine() ?? "";
    }
    return arr;
}

int GetPositivUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}