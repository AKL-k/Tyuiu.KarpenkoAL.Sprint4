using Tyuiu.KarpenkoAL.Sprint4.Task7.V16.Lib;

DataService ds = new DataService();

int rows = 5;
int columns = 3;
int[,] mtrx = new int[rows, columns];

string str = "382976421897948";

Console.Title = "Спринт #4 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 5 на 3 и п *");
Console.WriteLine("* одсчитайте произведение четных чисел.                                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int index = 0;

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++) 
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(rows, columns, str);

Console.WriteLine("Произведение элементов массива = " + res);
Console.ReadKey();



