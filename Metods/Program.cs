//  1 Метод только возвращает что-то
void Method1()
{
    Console.WriteLine("*** I am men ***");
}

Method1();



//  2 Вызов блока текста
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2("  Text ", 1);

Method2(msg: "Good", count: 2);

Method2(count: 3, msg: "     You");



//  3 Метод ничего не принимает, только возвращает
int Method3()
{
    return DateTime.Now.Year;
}

int yr = Method3();
Console.WriteLine(yr);



//  4 Метод принимает и возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string tex = Method4(10, "  /*_*| ");
Console.WriteLine(tex);

string Method5(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
    result = result + text;
    }
    return result;
}

string tex2 = Method5(8, "_/|)_");
Console.WriteLine(tex2);

