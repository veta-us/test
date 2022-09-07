int[,,] Fill3DimArray(int A, int B, int C)
{
    System.Random numberSyntezator = new System.Random();
    int[,,] array3D = new int[A, B, C];

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = numberSyntezator.Next(0,100);
            }

        }
    }
    return array3D;

}




int[,,] array3D = Fill3DimArray(2, 2, 2);
Console.WriteLine(array3D);