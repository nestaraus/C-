using System.Text;
using System;
// вид 1
void Method1()
{
    Console.WriteLine("Автор Дмитрий");
}
Method1();

// вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i =0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"Текст", count: 4);

// вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
 Console.WriteLine(year);

 // вид 4


string Method4(int count, string c)
{
    int i =0;
    string result =String.Empty;
    while (i<count)
    {
        result=result+c;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);