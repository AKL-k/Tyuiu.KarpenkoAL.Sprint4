using Tyuiu.KarpenkoAL.Sprint4.Task4.V1.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значен *");
Console.WriteLine("* иями с клавиатуры в диапазоне от 1 до 9. Найдите сумму четных элементов *");
Console.WriteLine("* массива.                                                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбов в массиве: ");
int сolumns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, сolumns];

Console.WriteLine("***************************************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < сolumns; j++) 
    {
        Console.Write($"Введите {i},{j} элемент массива: ");
        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; ++i) 
{
    for (int j = 0; j < сolumns; j++) 
    {
        Console.Write($"{mtrx[i,j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(mtrx);

Console.WriteLine("Сумма четных элементов массива = " + res);
Console.ReadKey();




