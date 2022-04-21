//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int number = Input("Введите число, которое нужно возвести в степень");
int powerOfNumber = Input("Введите степень числа");
int result = number;

if (powerOfNumber>1)
{
        for (int i = 1; i < powerOfNumber; i++)
    {
        result = number * result;
    }
    Console.WriteLine(result);

}
else Console.WriteLine($"Введенная степень {powerOfNumber} не является натуральным числом");

int Input(string text)
    {
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    }