// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int SIZE = 6;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;
int[] array = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(array); 
System.Console.WriteLine($"Количество чётных чисел в сгенерированном массиве равно {GetSum(array)}");


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
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] % 2 == 0) {count ++;}
    }
      return count;
} 

void printArray(int[] arr){
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

