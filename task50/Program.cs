// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void output_array(int[,] arr, int num1, int num2)
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
int get_item(int[,] array, int vert, int gorizont)
{
    int rez = array[vert-1,gorizont-1];
    return rez;
}
Console.Write("Введите колличество строк массива: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
int[,] new_array = get_array(arr_dim1,arr_dim2);
output_array(new_array, arr_dim1,arr_dim2);
Console.Write("Введите строку искомого элемента: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец искомого элемента: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if ((num1<arr_dim1)&(num2<arr_dim2))
{
    Console.WriteLine("Искомый элемент = "+get_item(new_array, num1, num2));
}
else
{
    Console.WriteLine("такого числа в массиве нет");
}
;