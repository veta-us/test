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

//Метод решения задачи 33 (простой) true false
bool ColculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    
    int i = 0;
    while (i < 12)
    {
        if(inputArray[i]==searchNumber)
        {
            resultSearch = true;
            break;
        }
    
        i++;
    }
    return resultSearch;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Введите число для поиска:");
int searchNumber= int.Parse(Console.ReadLine()); // пользователь вводит число, и преобразовывает его 

Console.WriteLine(ColculateTask(bufferArray, searchNumber));



