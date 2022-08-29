int sideA = 0;
int sideB = 0;
int sideC = 0;

Read();
bool res = TestTriangle(sideA, sideB, sideC);
PrintAnswer(res);

void Read() //метод считываетвведеные стороны треугольника
{
    Console.Write("Введите число 1: ");  // пользователь видит инструкцию, вводит число
    sideA = int.Parse(Console.ReadLine() ?? ""); // переменная стороны считывается с консоли, и преобразуется в число
    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ?? "");

}

bool TestTriangle(int num1, int num2, int num3) // метод подсчета и сама задача
{
    bool answer = ((num1 + num2 > num3)
    && (num2 + num3 > num1)
    && (num1 + num3 > num2)) ? true : false;
   // perem = (условие) ? что выбрать значение1(которое выполниться): занчение 2(иначе выполнится); 

    return answer; // возвращает переменную ансвер, с которой этот метод проигрался
    
}

void PrintAnswer(bool answer) // метод печать результаат 
{
    if (answer)
    {
        Console.WriteLine("Из этих ответов можно составить треугольник");
    }
    else
    {
        Console.WriteLine("Из этих ответов нельзя составить треугольник");

    }

}

