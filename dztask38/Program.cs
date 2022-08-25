// метод возвращает массив заполненный случайными числами 
int[] FillingArray()
{
    
    int[] outArray = new int[15];
    //буферная переменная
    int i = 0;
    //создаем экземпляр класса рандомайзер
    System.Random numberSintesator = new System.Random();
    
    while(i < 15)
    {
     //Получаем новое значение
       outArray[i] = numberSintesator.Next(10,100);
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

//Метод решения задачи 36 (простой) 
int ColculateTask(int[] inputArray) //принимаем массив 
{
   
    int i = 1;
    int max=0;
    int min=int.MaxValue;

    while (i < inputArray.Length) //проходим массив
    {
       if(inputArray[i]>max) //
        {
          max=inputArray[i];

        }
        if(inputArray[i]<min) //
        {
          min=inputArray[i];

        }
       
       
    
        i++; // так проходим по массиву
    }
    return(max - min);
}

// буфферный массив
int[] bufferArray = FillingArray();
// печатаем этот массив
PrintIntArray(bufferArray);
int Otvet = ColculateTask(bufferArray);
Console.WriteLine(ColculateTask(bufferArray));


