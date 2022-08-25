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
       outArray[i] = numberSintesator.Next(100,1000);
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

//Метод решения задачи 33 (простой) true false
int ColculateTask(int[] inputArray) //принимаем массив 
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length) //проходим по всему массиву
    {
        if(inputArray[i]%2==0) //элемент массива больше нижней границы и меньше верхней границы 
        {
           resultCount++; //если ок, то увеличиваем переменную 
        }
    
        i++; // так проходим по массиву
    }
    return resultCount;
}
// буфферный массив
int[] bufferArray = FillingArray();
// печатаем этот массив
PrintIntArray(bufferArray);

//сразу печатаем результат
Console.WriteLine(ColculateTask(bufferArray));
