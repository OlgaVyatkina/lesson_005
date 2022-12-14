// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int SIZE = 10;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 100;
double [] array = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(array); 
Console.WriteLine($"Разница между максимальным и минимальными элементами: {GetDiff(array)}");


double [] GetArray(int  SIZE, int LEFT_RANGE, int RIGHT_RANGE){
    double[] arr = new double[SIZE];
    Random rand = new();
    for (int i = 0; i < SIZE; i++)
    {
        arr[i] = Math.Round(rand.Next(LEFT_RANGE, RIGHT_RANGE + 1) + rand.NextDouble(), 2);
    }
        return arr;
}
double GetDiff(double[] arr){ 
    double max = arr[0]; 
    double min =arr[0];
    for (int i = 0; i < arr.Length; i++){
    if (arr[i] > max) { max = arr[i]; }
    else if  (arr[i] < min) { min = arr[i]; }
   }
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
   return max - min;
}

void printArray(double[] arr){
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}



