/*
int[,] pic = new int[,]
{
{1,5,3,9},
{5,6,0,8},
{9,1,8,3},
};

void ShowArray(int [,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void CreatedArray(int [,]array , int rows, int col )
{
    if(rows-1<array.GetLength(0) && col-1<array.GetLength(1)&&rows>0 && col>0)
    {
    int i =rows-1;
    int j =col-1;
    Console.WriteLine($"Ваше число: -> {array[i,j]}");
    }
    else Console.WriteLine("Данного значения не существует");
}
Console.WriteLine();
Console.WriteLine("Выберети ряд и столбик из двумерного массива что ниже: ");
ShowArray(pic);
Console.WriteLine();
Console.WriteLine("ряд: ");
int stob = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("столбец: ");
int col = Convert.ToInt32(Console.ReadLine());

CreatedArray(pic,stob,col);
*/


//2 задача

int[,] Fill2Array(int rows, int col)
{


    int[,] filledArray = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            filledArray[i, j] = new Random().Next(1, 10);
        }
    }
    return filledArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array, int cols)
{
    int newI = 0;
    double res = 0;
    int num = 1;
    while (newI < cols)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res+=array[j,newI];
            
            

            for (int i = 0; i < array.GetLength(0); i++)
            {

            }

        }
        Console.WriteLine($"|{num}столбец->{Math.Round((res/cols), 2)}|");
        num ++;
        res = 0;
        newI++;
    }
}

Console.WriteLine("строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] newArray = Fill2Array(rows, col);
ShowArray(newArray);
Console.WriteLine();
PrintArray(newArray, col);

