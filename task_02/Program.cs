// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int SIZE = 10;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;
int[] array = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(array); 
System.Console.WriteLine($"Сумма чисел элементов с нечетными индексами в сгенерированном массиве {GetSum(array)}");


int [] GetArray(int  SIZE, int LEFT_RANGE, int RIGHT_RANGE){
    int[] arr = new int[SIZE];
    for (int i = 0; i < SIZE; i++)
    {
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE + 1);
    }
        return arr;
}

int GetSum(int[] arr){ 
    int count = 0; 
    for (int i = 1; i < arr.Length; i+=2)
    { count = count + arr[i]; }
    return count;
    }

void printArray(int[] arr){
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}


