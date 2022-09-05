//.................
//Задайте двумерный массив из целых чис­ел. Напишите программу, которая поменяет первую и треть стрчоки массива 
//.
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

int [,] RotateRowFirstLast(int [,] inputArray) // метод меняет местами первую и последюю строчки
{
    int bufferElement = 0;
    int i= 0; int j = 0;

    while (j< inputArray.GetLength(1))
    {
        // блок ротации элементов в столбце
        bufferElement = inputArray[0,j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
        j++;
    }
    return inputArray;

}
  // вызываем массивы
int[,] twoDimArray = FillTwoDimArray(7, 5);
PrintColorTwoDimArray(twoDimArray);

Console.WriteLine();
PrintColorTwoDimArray(RotateRowFirstLast(twoDimArray));




54 // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] twoDimArray = FillTwoDimArray(7, 5);
PrintColorTwoDimArray(twoDimArray);

3. int [,] Filter(int [,] inputArray) // метод меняет местами первую и последюю строчки
{
    
int i = 0; int j = 0;
  
      while (i < inputArray.GetLength(0))
      {
            j = 0;
            int[] = new b
            while (j < inputArray.GetLength(1))
            {
                 bool<= a
                  j++;
            }
            Console.Write("\n");
            b = Sort(b)
            j = 0; 
            while 
            {
                 a<= b
                 j++
            }
         
            i++;
      }
    return inputArray;

}


56 
1, 2 метода одинаковые 

3. int FindRow(int[,] a)
{
    int i = 0; int j = 0;
    int min = 0;
    ind
  
      while (i < inputArray.GetLength(0))
      {
            j = 0;
            int b =0;
            while (j < inputArray.GetLength(1))
            {
                b+= a[]
                b++ 
                
                  
                  j++;
            }
            if (b<min) b=min
            ind = i;
           
         
            i++;
      }
      return ind
}





