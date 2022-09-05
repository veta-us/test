// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindRow(int [,] inputArray) // 
{
    int i = 0; int j = 0;
    int min = 0;
    int ind =0;
    int[,] outArray = new int[ind, j];
  
      while (i < inputArray.GetLength(0))
      {
            j = 0;
            int b =0;
            while (j < inputArray.GetLength(1))
            {
                b = inputArray[i,j];
                b++;
                j++;
            }
            if (b<min); 
            {
                b=min;
                ind = i;
            }
            i++;
      }
      Console.WriteLine(ind);

}





int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);
FindRow(twoDimArray);


