// Дана строка символов.
// 1) Напечатать часть строки от предпоследней до последней запятой.
// 2) Определить количество слов, заканчивающихся на сочетание "ай".
// 3) Напечать среднее (по расположению в строке) слово.
// 4) Определить количество слов, длина которых более 10 символов.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // 1) Напечатать часть строки от предпоследней до последней запятой.

        int LastIndex = input.LastIndexOf(',');
        int PreLastIndex = input.LastIndexOf(',', LastIndex - 1);
        if (PreLastIndex != -1 && LastIndex != -1)
        {
            Console.Write("Часть строки от предпоследней до последней запятой:");
            Console.WriteLine(input.Substring(PreLastIndex + 1, LastIndex - PreLastIndex - 1));
        }
        else
        {
            Console.WriteLine("В строке недостаточно запятых.");
        }

        // 2) Определить количество слов, заканчивающихся на сочетание "ай".

        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (var word in words)
        {
            if (word.EndsWith("ай"))
            {
                count++;
            }
        }
        Console.WriteLine($"Количество слов, заканчивающихся на 'ай': {count}");

        // 3) Напечатать среднее (по расположению в строке) слово.

        if (words.Length > 0)
        {
            Console.WriteLine($"Среднее слово: {words[words.Length / 2]}");
        }
        else
        {
            Console.WriteLine("Слов в строке не обнаружено.");
        }

        // 4) Определить количество слов, длина которых более 10 символов.

        int LongWordsCount = 0;
        foreach (var word in words)
        {
            if (word.Length > 10)
            {
                LongWordsCount++;
            }
        }
        Console.WriteLine($"Количество слов, длина которых более 10 символов: {LongWordsCount}");
    }
}