// Задача 29: Напишите программу, в которую пользователь задает через запятую 8 чисел, а программа выведет их в виде массива
string[] array = new string[8];
int[] arrayResult = new int[8];
Console.Write("Введите 8 чисел через запятую: ");
string input = Console.ReadLine();

string noDots = Replace(input, ' '); //не очень понимаю почему без этого не работает - не дает потом конвертировать в int
int arrayIndex = 0;

for (int i = 0; i < noDots.Length; i = i + 2)
{
    array[arrayIndex] = $"{noDots[i]}";
    arrayIndex++;
}

arrayIndex = 0;

for (arrayIndex = 0; arrayIndex < array.Length; arrayIndex++)
{
    arrayResult[arrayIndex] = Convert.ToInt32(array[arrayIndex]);
    Console.Write($"{arrayResult[arrayIndex]} ");
}

string Replace(string text, char oldValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] != oldValue) result = result + $"{text[i]}";
    }

    return result;
}