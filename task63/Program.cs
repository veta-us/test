// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// мое решение 

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
    if(num1-1 == num2) return num1; 
    else
    {
       num2--; 
    
       Console.Write(NuturalNumber(num1, num2) + " ");
    }
    return num2;
}



// Вызов методов
int inputNumber1 =  ReadDataStart();
int inputNumber2 =  ReadDataFinish();
NuturalNumber(inputNumber1, inputNumber2+2);

// Решение с семинара 
// // метод считывает число, введенное пользователем 
// int  ReadData()
// {
//     Console.WriteLine("Задайте число: "); // просим ввести число
//     return int.Parse(Console.ReadLine());// возвращаем число, которое ввел пользователь. при этом делаем преобразование Parse
// }

// //  стек 
// // 1 число 3 на вход
// // 2 попадет 2, она войдет в int NuturalNumber(int num) и вернет 1 


// int NuturalNumber(int num)
// {
//     if(num == 2) return 1;
//     else
//     {
//        num--; 
//        Console.WriteLine(num);
//        Console.Write(NuturalNumber(num) + " ");
//     }
//     return num;
// }

// int inputNumber =  ReadData();
// NuturalNumber(inputNumber+2);


