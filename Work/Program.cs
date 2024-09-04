string[] array = { "Hi", "Gee", "Brains", ":-)", "Hello World" };

int count = 0;
foreach (string symbol in array)
{
    if (symbol.Length <= 3)
    {
        count++;
    }
}

string[] result = new string[count];

int index = 0;

foreach (string symbol in array)
{
    if (symbol.Length <= 3)
    {
        result[index] = symbol;
        index++;
    }
}

Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
Console.WriteLine("[" + string.Join(", ", result) + "]");