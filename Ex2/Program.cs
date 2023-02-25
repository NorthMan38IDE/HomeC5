// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GenArray(int length){                // Генератор
    int[] mass = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rnd.Next(-10, 10);
    }
    return mass;}
//----------------------------------------------
void PrintArr(int[] array){                // Вывод массива
    for (int i = 0; i < array.Length; i++)
    {   
        System.Console.Write(array[i] + " ");
    }}
//---------------------------------------------
int SumPositiveElements(int[] array){      // Сумма элементов, находящихся на нечетных индексах элементов
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
        
    }
    return sum;}
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
System.Console.WriteLine($"Сумма элементов, находящихся на нечетных индексах в массиве равна: {SumPositiveElements(array)}");
