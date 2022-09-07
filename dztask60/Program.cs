// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, 
//которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.массив размером 2 x 2 x 2


// метод создает трехмерный массив и заполняет его рандомными числами
int[,,] Fill3DimArray(int A, int B, int C) //на вход принимаем три числа, три размерности 
{
    System.Random numberSyntezator = new System.Random();
    int[,,] array3D = new int[A, B, C];
    // сколько циклов, такая и размерность. в данном случае три цикла for, они заполняют по очереди массив

    for (int i = 0; i < array3D.GetLength(0); i++) 
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = numberSyntezator.Next(0, 100);
            }

        }
    }
    return array3D; 

}

// метод печатает массив
void Print(int[,,] a)  
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
                Console.Write(a[i, j, k]  + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------");
    }
}

// вызываем методы
int[,,] array3D = Fill3DimArray(2, 2, 2);
Print(array3D);
