using Tyuiu.KarpenkoAL.Sprint4.Task3.V22.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статич *"); 
Console.WriteLine("* ескими значениями в диапазоне от 4 до 9. Найдите максимальный элемент в *");
Console.WriteLine("* первой строке массива.                                                  *");
Console.WriteLine("*                                                                         *");

int[,] mas2 = new int[5, 5] { { 4, 4, 7, 8, 9 },
                              { 9, 5, 9, 7, 8 },
                              { 7, 4, 9, 4, 6 },
                              { 4, 4, 7, 4, 4 },
                              { 4, 5, 8, 6, 7 } };

int rows = mas2.GetLength(0);
int columns = mas2.GetLength(1);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Mассив: ");
for (int j = 0; j < columns; j++) 
{
    Console.WriteLine($"{mas2[0, j]} \t");
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(mas2);

Console.WriteLine("Максимальное число в первой строке = " + res);
Console.ReadKey();