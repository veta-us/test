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
       outArray[i] = numberSintesator.Next(-10,10);
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
    int resultCount = 0;
    int i = 1;
    while (i < inputArray.Length) //проходим только по нечетным, потому что начали с единицы и увеличиваем на два итератор
    {
       resultCount = resultCount+inputArray[i];
    
        i+=2; // так проходим по массиву
    }
    return resultCount;
}

// буфферный массив
int[] bufferArray = FillingArray();
// печатаем этот массив
PrintIntArray(bufferArray);



int Otvet = ColculateTask(bufferArray);
Console.WriteLine(ColculateTask(bufferArray));

