// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 
int[] GenArray(int length){                                     // Генератор
    int[] mass = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rnd.Next(1, 100);
    }
    return mass;}
//----------------------------------------------
void PrintArr(int[] array){                                     // Вывод массива
    for (int i = 0; i < array.Length; i++)
    {   
        System.Console.Write(array[i] + " ");
    }}
//---------------------------------------------
int MinMaxValues(int[] array){      // Нахождение минимального и максимального значения
    int minVal = array[0];
    int maxVal = array[1];
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > maxVal) maxVal = array[i];
        if (array[i] < minVal) minVal = array[i];
        }
    result = maxVal - minVal;
    return result;}
//---------------------------------------------
int InputSize(string msg){                 // Ввод размера массива
     System.Console.Write($"{msg}");
     return Convert.ToInt32(System.Console.ReadLine());}
//---------------------------------------------

int sizeArray = InputSize("введите размер массива > ");
int[] array = GenArray(sizeArray);
System.Console.WriteLine("--------------------------");
System.Console.Write("Массив элементов:");
PrintArr(array);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {MinMaxValues(array)}");

