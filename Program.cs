using System.Text;
// Задание 1
//  Console.WriteLine("Введите слово: ");
//  string word = Console.ReadLine();
//  int c = 0;
// foreach (char i in word.ToLower())
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
// if (answer.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }
  

// Задание 4
// Console.Write("Введите номер: ");
// string answer = Console.ReadLine();
// string a=answer.Substring(0, 4);
// string b =answer.Substring(5,2);
// string c = answer.Substring(8, 2);
// Console.WriteLine($"{c}.{b}.{a}");

// Console.Write("Введите номер: ");
// string num = Console.ReadLine();
// string c1 = num.Substring(1, 3);
// string c2 = num.Substring(4, 3);
// string c3 = num.Substring(7, 2);
// string c4 = num.Substring(9, 2);
// Console.WriteLine($"+7 ({c1}) {c2}-{c3}-{c4}");



// Задание 5
// Console.Write("Введите строку: ");
// string answer = Console.ReadLine();
// string r = "аеёиоуыэюя";
// int c = 0;
// int p = 0;
// int g = 0;
// foreach (char i in answer.ToLower())
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
// if (b.ToLower() == answer.ToLower())
//     {
//         Console.WriteLine("Является");
//     }
//     else
//     {
//         Console.WriteLine("не Является");
//     }



// Итоговая задача. «Проверка email» 
Console.Write("Введите строку: ");
string answer = Console.ReadLine();
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
foreach (char i in answer){
    c1++;
    if (i == '@'){
        c2++;}
    if (i == ' '){
        c3++;}}
string lower = answer.ToLower();
if (answer.StartsWith("@")){
    c4++;}
if (answer.EndsWith("@")){
    c5++;}
if (c1 < 5){
    Console.WriteLine("Адрес некорректен: слишком короткий (меньше 5 символов).");}
else if (c2 != 1){
    Console.WriteLine($"Адрес некорректен: должен быть ровно один @ (найдено {c2}).");}
else if (c4 != 0 || c5 != 0){
    Console.WriteLine("Адрес некорректен: не должен начинаться или заканчиваться на @.");}
else if (c3 > 0){
    Console.WriteLine("Адрес некорректен: содержит пробелы.");}
else if (!(lower.EndsWith(".ru") || lower.EndsWith(".com"))){
    Console.WriteLine("Адрес некорректен: должен заканчиваться на .ru или .com.");}
else{
    Console.WriteLine("Адрес корректен");
    Console.WriteLine(lower);}




// Дополнительное задание ★★★ 
// Console.Write("Введите строку: ");
// string answer = Console.ReadLine();
// var sb = new StringBuilder();
// string a = "аеёиоуыэюя";
// foreach (char i in answer.ToLower()) 
// {
//     if (a.Contains(i))
//     {
//         continue;
//     }
//     else
//     {
//         sb.Append(i);
//     }
// }
// Console.WriteLine(sb);