//.................
//Задайте двумерный массив из целых чис­ел. Найдите среднее арифметическое элеме­нтов 
//в каждом столбце.
//...........
  
// метод для заполне­ния двумерного масси­ва
int[,] FillTwoDimArray(int countRow, int countColumn)
{
      System.Random numberSyntezator = new System.Random();
      int i = 0;
      int j = 0;
      int[,] outArray = new int[countRow, countColumn];
      while (i < countRow)
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
  
// Метод подсчета ср­еднего арифметическо­го каждого столбца
double CalcAverage(int[,] inputArray)
{
      double outAverageColumn = 0;
      int j = 0;
      while (j < inputArray.GetLength(1))
      {
            int i = 0;
            outAverageColumn = 0;
            while (i < inputArray.GetLength(0))
            {
                  outAverageColumn = outAverageColumn + inputArray[i, j];
                  i++;
            }
            outAverageColumn = outAverageColumn / inputArray.GetLength(0);
            Console.Write(Math.Round(outAverageColumn, 2) + "; ");
            j++;
      }
  
      return outAverageColumn;
}
  
ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.Green };

  
void PrintColorTwoDimArray(int[,] inputArray)
{
      int i = 0; int j = 0;
  
      while (i < inputArray.GetLength(0))
      {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                  Console.ForegroundColor = col[new System.Random().Next(0, 7)];
                  Console.Write(inputArray[i, j] + "\t");
                  Console.ResetColor();
                  j++;
            }
            Console.Write("\n");
         
            i++;
      }
}
  
int[,] twoDimArray = FillTwoDimArray(7, 5);
PrintColorTwoDimArray(twoDimArray);
Console.Write($"\nCреднее арифметическ­ое:\n");
CalcAverage(twoDimArray);
