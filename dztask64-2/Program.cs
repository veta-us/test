//Задайте значение  N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// метод считывает число, введенное пользователем 
int  ReadData()
{
    Console.WriteLine("Задайте число: "); // просим ввести число
    return int.Parse(Console.ReadLine());// возвращаем число, которое ввел пользователь. при этом делаем преобразование Parse
}




// метод выдает натуральные числа в промежутке от M до N, которые ввел пользователь 
int NuturalNumber(int num)
{
  
    if(num == 2) {Console.Write(1);} 
    else
    {
      num --;
      Console.Write(num);
      NuturalNumber(num);
    //   Console.WriteLine(NuturalNumber(num) + " ");
    }
    return num;
}

int inputNumber =  ReadData();
NuturalNumber(inputNumber+1);


