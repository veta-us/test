// метод считывает число, введенное пользователем 
int  ReadData()
{
    Console.WriteLine("Задайте число: "); // просим ввести число
    return int.Parse(Console.ReadLine());// возвращаем число, которое ввел пользователь. при этом делаем преобразование Parse
}




int NuturalNumber(int num)
{
    if(num == 2) return 1;
    else
    {
       num--; 
       Console.WriteLine(num);
       Console.Write(NuturalNumber(num) + " ");
    }
    return num;
}


int inputNumber =  ReadData();
NuturalNumber(inputNumber+2);

