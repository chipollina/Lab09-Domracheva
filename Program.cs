// Задание 1
//  Console.WriteLine("Введите слово: ");
//  string word = Console.ReadLine();
//  int c = 0;
// foreach (char i in word)
// {
//     if (i == 'а')
//     {
//         c++;
//     }
//  }
//  Console.WriteLine($"Количество букв: {c}");

// Задание 2
// Console.Write(":");
// string fileName = Console.ReadLine();
// if (fileName.EndsWith(".cs"))
// {
//     Console.WriteLine("Это файл С#");
// }
// else if (fileName.EndsWith(".png"))
// {
//     Console.WriteLine("Это файл изображение");
// }
// else if (fileName.EndsWith(".jpg"))
// {
//     Console.WriteLine("Это файл изображение");
// }
// else
// {
//     Console.WriteLine("неизвестный тип");
// }
// if (fileName.StartsWith("Lab"))
// {
//     Console.WriteLine("Это лабораторная работа");
// }
// if (fileName.Contains("test"))
// {
//     Console.WriteLine("Тестовый файл");
// }

// Задание 3
// Console.Write("Введите фразу: ");
// string answer = Console.ReadLine();
// Console.WriteLine(answer.ToUpper());
// Console.WriteLine(answer.Replace(" ", "_"));
// string a = answer.ToLower();
// foreach (char i in a)
// {
//     if (answer.Contains("стоп"))
//     {
//         Console.WriteLine("Стоп-слово найдено!");
//         break;
//     }
// }

// Задание 4
// Console.Write("Введите номер: ");
// string answer = Console.ReadLine();
// string a=answer.Substring(0, 4);
// string b =answer.Substring(5,7);
// string c = answer.Substring(8);
// Console.WriteLine(a,b,c);

// Console.Write("Введите номер: ");
// string num = Console.ReadLine();


// Задание 5
// Console.Write("Введите строку: ");
// string answer = Console.ReadLine();
// string r = "аеёиоуыэюя";
// int c = 0;
// int p = 0;
// int g = 0;
// foreach (char i in answer)
// {
//     c++;
//     if (i == ' ')
//     {
//         p++;
//     }
// }
// foreach (char i in r)
// {
//     if (answer.Contains(i))
//     {
//         g++;
//     }
// }
// Console.WriteLine(c);
// Console.WriteLine(p);
// Console.WriteLine(g);

// Задание 6
// Console.Write("Введите строку: ");
// string answer = Console.ReadLine();
// string b = "";
// for (int i = answer.Length - 1; i >= 0; i--)
// {
//     b += answer[i];
// }
// Console.WriteLine(b);
// if (b == answer)
//     {
//         Console.WriteLine("Является");
//     }
//     else
//     {
//         Console.WriteLine("не Является");
//     }

// Задание 7
Console.Write("Введите строку: ");
string answer = Console.ReadLine();
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
foreach (char i in answer)
{
    c1++;
    if (i == '@')
    {
        c2++;
    }
    if (i == ' ')
    {
        c3++;
    }
}
if (answer.StartsWith("@"))
{
    c4++;
}
if (answer.EndsWith("@"))
{
    c5++;
}