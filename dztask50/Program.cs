//......................
// ................
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//  возвращает значение этого элемента или же указание, что такого элемента нет.
// ..................


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

// массив цветов (из этого массива будет выбираться рандомно цвет)
ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.Green };


void PrintColorTwoDimArray(int[,] inputArray) // метод раскрашивает данные в любой цвет  и печатает 
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

// метод bool, который проверяет есть ли заданное числов  массиве

bool SearchElement(int[,] inputArray, int E)
{
    bool answer = false;
    int i = 0; int j = 0; //
    while (i < inputArray.GetLength(0) )// два цикла, пока не заполним столбцы и строчки
    {
        j = 0;
       while (j < inputArray.GetLength(1))
        { 
            if (inputArray[i,j] == E)
            {
                answer = true;
            }
            j++;
        }
        i++;
    }
    return answer;
}

// метод печатает ответ, есть число в массиве или нет
void PrintAnswer(bool answer) // принимает на входе переменную answer, в которой содержится true false
{

    if (answer)
    {
        Console.WriteLine("Это число есть в массиве");
    }
    else
    {
        Console.WriteLine("Этого числа нет в массиве");

    }

}

//вызываем методы
int[,] twoDimArray = FillTwoDimArray(5,8); // задает массив размеров 5 на 8
PrintColorTwoDimArray(twoDimArray); // печатает заданный массив, чтобы его увидел пользователь
bool res = SearchElement(twoDimArray, int.Parse(Console.ReadLine())); // принимает массив, с которым мы рабоатем и введеное с консоли пользователем число
PrintAnswer(res); // печататет ответ задачи, найдет элемент или нет



