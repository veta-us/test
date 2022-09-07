int[,,] FillTwoDimArray(int A, int B, int C)
{
      System.Random numberSyntezator = new System.Random();
      int i = 0;
      int j = 0;
      int k =0;
      int[,,] outArray = new int[A, B, C];
      while (i < A)
      {
            j = 0;
            while (j < B)
            {
                 while (k < C)
                 {
                  outArray[i, j, k] = numberSyntezator.Next(0, 101);
                  k++;
                 }
                  j++;
            }
            i++;
      } 
      return outArray;
}



int[,,] array3D = FillTwoDimArray(2, 2, 2);
Console.WriteLine(array3D);