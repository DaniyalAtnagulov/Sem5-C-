// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Enter array size  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
GetArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"max number is {max}, min number is {min}");
Console.WriteLine($"The difference between min and max = {max - min}");

void GetArray(double[] arraynumbers)
{
    for(int i = 0; i < arraynumbers.Length; i++)
        {
            arraynumbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
            
            Console.Write($"{arraynumbers[i]} ");
        }
        
}
