// метод возвращает двумерный массив заполненный случайными числами 
int[,] FillTwoDimArray(int countRow, int countColumn) //принимаем значения строчек и столбцов
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0; //
    int[,] outArray = new int[countRow, countColumn]; // новый массив, строчек и столбов
    while (i < countRow) // два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }

        i++;
    }
    return outArray;
}


//Метод печатает массив
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0)) // два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.Write("\n");
        i++;
    }
}

ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.Green };


void PrintColorTwoDimArray(int[,] inputArray) // метод раскрашивает данные в жедтый цвет
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0)) // два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 8)];
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        Console.Write("\n");
        i++;
    }
}

int[,] UpdateTwoDimArray(int[,] inputArray)
{
    int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0)) // два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i % 2 == 0 && j % 2 == 0)
    {
    outArray[i, j] = inputArray[i, j] * inputArray[i, j];
}
else
{
    outArray[i, j] = inputArray[i, j];
}

j++;
   }
    i++; 
} 
 return outArray;
}


int[,] twoDimArray = FillTwoDimArray(5, 8);

PrintColorTwoDimArray(twoDimArray);
PrintColorTwoDimArray(UpdateTwoDimArray(twoDimArray));
