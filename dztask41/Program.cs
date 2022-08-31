// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа");
int m = int.Parse(Console.ReadLine());  // вот где-то в начале я не могу разобраться с этими переменными
int[] num = new int[m];
int[] Read(int m) // метод считывает м, который вводит пользователь и возвращает заполненный массив buferarray

{
    int[] buferarray= new int[m];
    int i = 0;
    while (i < m)
    {
       buferarray[i] = int.Parse(Console.ReadLine()); 
       i++;
    }
    return buferarray;
}

int ColculateTask(int[] inputArray) //принимаем массив 
{
    int B = 0;
    int i = 0;
    while (i < inputArray.Length) //проходим массив
    {
       if(inputArray[i] > 0 ) //
        {
          B++;
        }
        i++; // так проходим по массиву
    }
    return(B); // возвращаем В, где лежит значение количества положительных чисел
}

void PrintResult(int B) // метод печатает наш ответ, то есть переменную B
{
    Console.WriteLine(B);
}

// вызываем методы
int[] array = Read(m);  
int res = ColculateTask(array);
PrintResult(res);











