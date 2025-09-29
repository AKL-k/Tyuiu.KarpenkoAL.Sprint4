using Tyuiu.KarpenkoAL.Sprint4.Task0.V23.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статиче *");
Console.WriteLine("* скими значениями в диапазоне от 0 до 9 подсчитать произведение нечетных *");
Console.WriteLine("* элементов массива. {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

Console.WriteLine("Исходный массив:");

for (int i = 0; i < numsArray.Length; i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.GetMultOddArrEl(numsArray);
Console.WriteLine("Произведение нечетных элементов = " + res);

Console.ReadKey();
