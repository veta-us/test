// Задайте значения M и N. Напишите программу,Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int sum = 0;

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
int NuturalNumberSum(int num1, int num2)
{
    if(num1-1 == num2) return sum; 

    sum = sum + num1;
    NuturalNumberSum(num1 +1, num2);
    return sum;
}

void PrintSum()
{
    Console.WriteLine(sum);
}


// Вызов методов
int inputNumber1 =  ReadDataStart();
int inputNumber2 =  ReadDataFinish();
NuturalNumberSum(inputNumber1, inputNumber2);
PrintSum();
