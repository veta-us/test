//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

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
void NuturalNumber(int num1, int num2)
{
    if(num1-1 == num2) return; 
    else
    {
      Console.Write(num1);
      NuturalNumber(num1+1, num2);
    }
    
}

int inputNumber1 =  ReadDataStart();
int inputNumber2 =  ReadDataFinish();
NuturalNumber(inputNumber1, inputNumber2);