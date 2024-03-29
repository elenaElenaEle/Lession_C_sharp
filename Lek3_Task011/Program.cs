﻿//Виды методов в C#
// Вид 1 - метод который ничего не возвращает и не принимает********************************************************************
void Method1 ()
{
    Console.WriteLine("Автор Елена "); // тело метода
}

Method1();       //как вызываются подобоного рода методы

// Вид 2 - методы которые ничего не возвращают, но могут принимать какие-то аргументы*********************************************
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // - инкримент - увеличение на 1
    }
}
Method21(msg: "Текст", count: 4);
Method21(count: 3, msg: "Новый текст"); // если аргументы именованы, не обязательно указывать по порядку

// Вид 3 - метод который что-то возвращает, но ничего не принимает*******************************************************************
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 - методы которые что-то принимают и что-то возвращают*************************************************************************

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

string res = Method4(6, "z");
Console.WriteLine(res);