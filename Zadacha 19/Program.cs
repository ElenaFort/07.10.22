/*Задача 19
Напишите программу, которая принимает на вход пятизначное
 число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void check_polindrom(string word)
{
    int n = word.Length;
    Console.Write($"{word}: ");
    for (int i = 0; i < n / 2; i = i++)
    {
        if (word[i] != word[n - i - 1])

            Console.WriteLine("не является полиндромом");
        else

            Console.WriteLine("является полиндромом");
        return;
    }
}

Console.WriteLine("Введите число: ");
string word1 = Console.ReadLine();

check_polindrom(word1);
