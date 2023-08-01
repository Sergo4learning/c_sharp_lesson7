// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Random rnd = new Random();
float[,] get_array(int num1, int num2)
{
    float[,] new_array = new float[num1,num2];    
    for (int i = 1; i<=num1; i++)
    {
        for (int j=1; j<= num2;j++)
        {
            new_array[i-1,j-1] = (float)Math.Round(rnd.NextDouble()*20-10,1);
        }        
    }    
    return new_array;
}
void output_array(float[,] arr, int num1, int num2)
{
    for (int i=1; i<=num1;i++)
    {
        for (int j=1; j<num2; j++)
        {
            Console.Write(arr[i-1,j-1]+", ");
        }
        Console.WriteLine(arr[i-1,num2-1]);
    }
}
Console.Write("Введите колличество строк массива: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
float[,] array = get_array(arr_dim1,arr_dim2);
output_array(array, arr_dim1,arr_dim2);