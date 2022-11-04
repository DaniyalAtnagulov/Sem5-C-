// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for (int i=0;i<size;i++){
        res[i]=new Random().Next(minValue, maxValue+1);
            // Console.Write($"{res[i]} ");
            
    }
    return res;
}
int CountOddElements (int[] arr){
    int sum=0;
    for (int z=1; z< arr.Length;z+=2)
    sum+=arr[z];
    return sum;
    
}
int[] array=GetArray(4,-100, 100); //В данном случае размер массива и ограничение размера чисел в нем ввел, ориентируясь на пример в задаче.
Console.WriteLine();
Console.Write ($"The sum of odd elements is {CountOddElements (array)}");
