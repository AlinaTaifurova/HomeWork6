/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!
                                      .Split(), int.Parse);
int count = array.Count(i => i > 0);
Console.WriteLine($"Количество элементов больше 0: {count}");