using Tyuiu.KarpenkoAL.Sprint4.Task1.V5.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный значени *");
Console.WriteLine("* ями с клавиатуры в диапазоне от 5 до 9 подсчитать сумму четных элементо *");
Console.WriteLine("* в массива. С клавиатуры: 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i < numsArray.Length; i++)
{
    Console.WriteLine("Введите значение " + i + "элемент массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Mассив: ");
for (int i = 0; i < numsArray.Length; i++) 
{
    Console.WriteLine(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine("Cумма четных элементов = " + res);

Console.ReadKey();
