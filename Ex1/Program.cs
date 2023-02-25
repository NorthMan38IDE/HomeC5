// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenArray(int length){ // Генератор
    int[] mass = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rnd.Next(1, 1000);
    }
    return mass;}
//----------------------------------------------
void PrintArr(int[] array){                // Вывод массива
    for (int i = 0; i < array.Length; i++)
    {   
        System.Console.Write(array[i] + " ");
    }}
//---------------------------------------------
int CountElements(int[] array){            // Счет четных элементов
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count = count + 1;
        }
        
    }
    return count;}
//---------------------------------------------
int InputSize(string msg){                  // Ввод размера массива
     System.Console.Write($"{msg}");
     return Convert.ToInt32(System.Console.ReadLine());}
//---------------------------------------------

int sizeArray = InputSize("введите размер массива > ");
int[] array = GenArray(sizeArray);
System.Console.WriteLine("--------------------------");
System.Console.Write("Массив элементов:");
PrintArr(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных чисел в массиве: {CountElements(array)}");

