// Задача 54. Домашнее задание.
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

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

int [,] Filter(int [,] inputArray) // метод меняет местами первую и последюю строчки
{ 
int i = 0; int j = 0;
  
      while (i < inputArray.GetLength(0))
      {
            j = 0;
            int[] b = new int[i];
            while (j < inputArray.GetLength(1))
            {
                 b = inputArray[i];
                  j++;
            }
            Console.Write("\n");
            Array.Sort(b);
            j = 0; 
            while (j < inputArray.GetLength(1))
            {
                 inputArray = b[i];
                 j++;
            }
         
            i++;
      }
    return inputArray;

}

int[,] bufferArray = FillTwoDimArray(3,5);
PrintColorTwoDimArray(bufferArray);
int [,] resultarray = Filter(bufferArray);
PrintColorTwoDimArray(resultarray);





 
            
            
