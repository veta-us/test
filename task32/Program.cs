// метод возвращает массив заполненный случайными числами от -9 до 9
int[] FillingArray()
{
    
    int[] outArray = new int[12];
    //буферная переменная
    int i = 0;
    //создаем экземпляр класса рандомайзер
    System.Random numberSintesator = new System.Random();
    
    while(i<12)
    {
     //Получаем новое значение
       outArray[i] = numberSintesator.Next(-9,10);
       //Увеличиваем инкримент 
       i++;
    }
    //Возвращаем значение
    return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буыерная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length -1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i]+ ", ");
       //Увеличиваем инкримент
        i++;
    }
    //Выводим эллемент массива
    Console.WriteLine(inputArray[i]);
}

//Метод инвертирует элементы массива (простой)
int[] ColculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i<12)
    {
        outputArray[i]=outputArray[i]*(-1);
   
        i++;
    }
    return outputArray;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);
