//Переменные для накопления результата
int posetivSum = 0;
int negativSum = 0;

//Метод возвращает массив заполненный случайнми числами от -9 до 9
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

//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i<12)
    {
        if(outArray[1]>0)
        {
           posetivSum++;
        }
        else{
            negativSum++;
        }
        i++;
    }


}

//метод принта результатов
void Print()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);
}

void VariantNaive()
{
    //вызов методов
int[] befferArrray = FillingArray();
ColculateTask(befferArrray);
Print();
}

VariantNaive();


