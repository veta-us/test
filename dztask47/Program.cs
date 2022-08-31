

// метод возвращает двумерный массив заполненный случайными числами 
double[,] FillTwoDimArray(int countRow, int countColumn) //принимаем значения строчек и столбцов
{
    System.Random numberSyntezator = new System.Random(); // создаем переменную рандома
    int i = 0; int j = 0; //
    double[,] outArray = new double[countRow, countColumn]; // новый массив, строчек и столбов
    while (i < countRow) // два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.NextDouble()*100; // заполняем массив рандомными вещественными числами
            j++;
        }

        i++;
    }
    return outArray;
}





// массив цветов (из этого массива будет выбираться рандомно цвет)
ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.Green };


void PrintColorTwoDimArray(double[,] inputArray) // метод раскрашивает данные в любой цвет
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0)) // два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 8)];
            Console.Write(inputArray[i, j] + " \t");
            Console.ResetColor();
            j++;
        }
        Console.Write("\n"); // завершить строчку
        i++;
    }
}

//вызываем методы
double[,] twoDimArray = FillTwoDimArray(5,8);
PrintColorTwoDimArray(twoDimArray);


