// метод возвращает массив заполненный случайными числами 
int[] FillingArray(int arrayLength)
{
    
    int[] outArray = new int[arrayLength];
    //буферная переменная
    int i = 0;
    //создаем экземпляр класса рандомайзер
    System.Random numberSintesator = new System.Random();
    
    while(i < arrayLength)
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

int[] ReversNewArray(int [] array)

{
    int length = array.Length;
    int [] newArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        newArray[length -1 -i] = array[i];
        // i=0 legth -1 -i = 12
        // i=1 legth -1 -i = 11
    }
    return newArray;

}

int[] testArray = FillingArray(13);
PrintIntArray(testArray);
int[] reversArray = ReversNewArray(testArray);
PrintIntArray(reversArray);
