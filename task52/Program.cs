// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random rnd = new Random();
int[,] get_array(int num1, int num2)
{
    int[,] new_array = new int[num1,num2];    
    for (int i = 1; i<=num1; i++)
    {
        for (int j=1; j<= num2;j++)
        {
            new_array[i-1,j-1] = rnd.Next(0,10);
        }        
    }    
    return new_array;
}
void output_1dim_array(float[] arr, int num)
{
    for (int i=1; i<num;i++)
    {
        Console.Write(arr[i-1]+"; ");
    }
    Console.WriteLine(arr[num-1]+".");
}
void output_2dim_array(int[,] arr, int num1, int num2)
{
    for (int i=1; i<=num1;i++)
    {
        for (int j=1; j<num2; j++)
        {
            Console.Write(arr[i-1,j-1]+" ");
        }
        Console.WriteLine(arr[i-1,num2-1]);
    }    
}
float[] get_avg(int[,] array, int num1, int num2)
{
    float[] new_array = new float [num2];
    for (int j=1;j<=num2;j++)
    {
        for (int i=1;i<=num1;i++)
        {
            new_array[j-1]=new_array[j-1]+ (float)Convert.ToDouble(array[i-1,j-1]);
        }
        new_array[j-1]=new_array[j-1]/(float)Convert.ToDouble(num1);
    }
    return new_array;
}
Console.Write("Введите колличество строк массива: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
int[,] my_array = get_array(arr_dim1,arr_dim2);
output_2dim_array(my_array, arr_dim1,arr_dim2);
float[] rez_array = get_avg(my_array, arr_dim1, arr_dim2);
Console.Write("Среднее арифметическое каждого столбца: ");
output_1dim_array(rez_array, arr_dim2);