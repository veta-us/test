// метод считывает число, введенное пользователем 
int  ReadDataStart()
{
    Console.WriteLine("Задайте начало отрезка: "); // просим ввести число
    return int.Parse(Console.ReadLine());// возвращаем число, которое ввел пользователь. при этом делаем преобразование Parse
}

int  ReadDataFinish()
{
    Console.WriteLine("Задайте конец отрезка: "); // просим ввести число
    return int.Parse(Console.ReadLine());// возвращаем число, которое ввел пользователь. при этом делаем преобразование Parse
}


// метод выдает натуральные числа в промежутке от M до N, которые ввел пользователь 
int NuturalNumber(int num1, int num2)
{
    if(num2 == num1) return num1; 
    else
    {
       num2--; 
      Console.WriteLine(num2);
       Console.Write(NuturalNumber(num1, num2) + " ");
    }
    return num2;
}




int inputNumber1 =  ReadDataStart();
int inputNumber2 =  ReadDataFinish();
NuturalNumber(inputNumber1, inputNumber2+2);