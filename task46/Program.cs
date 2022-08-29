// метод возвращает массив заполненный случайными числами 
int[] FillingArray(int arrayLength)
{
    int arrayLength = arrData[0];
    int arrayDown = arrData[1];
    int arrayUp = arrData[2];

int[] inputArray = new int[arrayLenght];
int i= 0;
System.Random numberSyntezator = new System.Random();
while (i < inputArray.Lenght)
{
    inputArray[i] = numberSyntezator.Next(arrayDown,arrayUp);
    i++
}
   
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
